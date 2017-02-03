using Mvvm.Winform.FluentBindingToolkit;

namespace Examples.Converters
{
    public class EnumToBooleanConverter<T> : IValueConverter<T, bool>
    {
        private readonly T _value;

        public EnumToBooleanConverter(T value)
        {
            _value = value;
        }

        public object ConvertViewModelToControl(T viewModelValue)
        {
            if (Equals(_value, viewModelValue)) {
                return true;
            }
            return BindingValue.None;
        }
        public object ConvertControlToViewModel(bool controlValue)
        {
            if (controlValue) {
                return _value;
            }
            return BindingValue.None;
        }
    }
}