namespace Mvvm.Winform.FluentBindingToolkit
{
    public interface IValueConverter<TViewModelValue, TControlValue>
    {
        object ConvertViewModelToControl(TViewModelValue viewModelValue);
        object ConvertControlToViewModel(TControlValue controlValue);
    }
}