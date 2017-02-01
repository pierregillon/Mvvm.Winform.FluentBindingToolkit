namespace Mvvm.Winform.BindingToolkit
{
    public interface IValueConverter<TViewModelValue, TControlValue>
    {
        object ConvertViewModelToControl(TViewModelValue viewModelValue);
        object ConvertControlToViewModel(TControlValue source);
    }
}