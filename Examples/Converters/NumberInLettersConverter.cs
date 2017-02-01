using Mvvm.Winform.BindingToolkit;

namespace Examples.Converters
{
    public class NumberInLettersConverter : IValueConverter<int, string>
    {
        public object ConvertViewModelToControl(int viewModelValue)
        {
            switch (viewModelValue) {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                default:
                    return "hum...";
            }
        }

        public object ConvertControlToViewModel(string controlValue)
        {
            return BindingValue.None;
        }
    }
}