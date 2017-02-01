using System;
using System.Windows.Forms;

namespace Mvvm.Winform.BindingToolkit
{
    public class BindingBuilder<TViewModelValue, TControlValue>
    {
        private readonly Binding _binding;

        public BindingBuilder(Binding binding)
        {
            _binding = binding;
        }

        public BindingBuilder<TViewModelValue, TControlValue> UseFormat(string format)
        {
            _binding.FormatString = format;
            return this;
        }

        public BindingBuilder<TViewModelValue, TControlValue> UseConverter(IValueConverter<TViewModelValue, TControlValue> converter)
        {
            var getCurrentControlValue = BuildGetCurrentControlValueFunction();
            var getCurrentViewModelValue = BuildGetCurrentViewModelValueFunction();

            _binding.Format += (sender, args) => {
                var newValue = converter.ConvertViewModelToControl((TViewModelValue) args.Value);
                if (newValue != BindingValue.None) {
                    args.Value = newValue;
                }
                else {
                    args.Value = getCurrentControlValue();
                }
            };

            _binding.Parse += (sender, args) => {
                var newValue = converter.ConvertControlToViewModel((TControlValue) args.Value);
                if (newValue != BindingValue.None) {
                    args.Value = newValue;
                }
                else {
                    args.Value = getCurrentViewModelValue();
                }
            };

            return this;
        }

        public BindingBuilder<TViewModelValue, TControlValue> TwoWay()
        {
            _binding.ControlUpdateMode = ControlUpdateMode.OnPropertyChanged;
            _binding.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            return this;
        }

        public BindingBuilder<TViewModelValue, TControlValue> OneWay()
        {
            _binding.ControlUpdateMode = ControlUpdateMode.OnPropertyChanged;
            _binding.DataSourceUpdateMode = DataSourceUpdateMode.Never;

            return this;
        }

        public BindingBuilder<TViewModelValue, TControlValue> OneWayToSource()
        {
            _binding.ControlUpdateMode = ControlUpdateMode.Never;
            _binding.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            return this;
        }

        private Func<object> BuildGetCurrentViewModelValueFunction()
        {
            var viewModel = _binding.DataSource;
            if (viewModel == null) {
                throw new Exception("A binding should be applied on viewmodel.");
            }
            var viewModelProperty = viewModel.GetType().GetProperty(_binding.BindingMemberInfo.BindingField);
            Func<object> getCurrentViewModelValue = () => viewModelProperty.GetValue(viewModel);
            return getCurrentViewModelValue;
        }
        private Func<object> BuildGetCurrentControlValueFunction()
        {
            var control = _binding.Control;
            if (control == null) {
                throw new Exception("A binding should be mapped to a control.");
            }
            var controlProperty = control.GetType().GetProperty(_binding.PropertyName);
            Func<object> getCurrentControlValue = () => controlProperty.GetValue(control);
            return getCurrentControlValue;
        }
    }
}