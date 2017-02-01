using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Mvvm.Winform.BindingToolkit
{
    public class ViewModelBinding<TViewModel, TControlValue>
    {
        private readonly Control _control;
        private readonly string _controlPropertyName;
        private readonly TViewModel _viewModel;

        public ViewModelBinding(Control control, string controlPropertyName, TViewModel viewModel)
        {
            _control = control;
            _controlPropertyName = controlPropertyName;
            _viewModel = viewModel;
        }

        public BindingBuilder<TViewModelValue, TControlValue> On<TViewModelValue>(Expression<Func<TViewModel, TViewModelValue>> expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression == null)
                throw new Exception($"Unable to create binding from expression that does not represent a Member : {expression}");

            var binding = CreateBinding(memberExpression);
            return new BindingBuilder<TViewModelValue, TControlValue>(binding);
        }

        private Binding CreateBinding(MemberExpression memberExpression)
        {
            var binding = new Binding(_controlPropertyName, _viewModel, memberExpression.Member.Name, true, DataSourceUpdateMode.OnPropertyChanged);

            _control.DataBindings.Add(binding);

            binding.BindingComplete += (sender, args) => {
                if (args.Exception != null) {
                    var form = _control.FindForm();
                    if (form?.IsHandleCreated == true) {
                        form.BeginInvoke(new Action(() => { throw new BindingException(binding.BindingMemberInfo.BindingField, binding.PropertyName, binding.Control?.Name, args.ErrorText); }));
                    }
                }
            };

            binding.Format += (sender, args) => {
                // HACK : Winform bug, when setting NULL to a viewModel property binded to SelectedItem, these control property is not updated.
                if (binding.Control is ComboBox && binding.PropertyName == "SelectedItem") {
                    var combobox = (ComboBox) binding.Control;
                    if (args.Value == null || args.Value == DBNull.Value) {
                        combobox.SelectedItem = null;
                    }
                }
            };

            return binding;
        }
    }
}