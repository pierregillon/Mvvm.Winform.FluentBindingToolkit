using Mvvm.Winform.BindingToolkit;

namespace Examples.Converters
{
    public class NotNullToBooleanConverter<T> : IValueConverter<T, bool>
    {
        public object ConvertViewModelToControl(T viewModelValue)
        {
            return viewModelValue != null;
        }
        public object ConvertControlToViewModel(bool controlValue)
        {
            return BindingValue.None;
        }
    }
}