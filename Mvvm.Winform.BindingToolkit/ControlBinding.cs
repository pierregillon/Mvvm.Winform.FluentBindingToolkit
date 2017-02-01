using System.Windows.Forms;

namespace Mvvm.Winform.BindingToolkit
{
    public class ControlBinding<TControlValue>
    {
        private readonly Control _control;
        private readonly string _controlPropertyName;

        public ControlBinding(Control control, string controlPropertyName)
        {
            _control = control;
            _controlPropertyName = controlPropertyName;
        }

        public ViewModelBinding<TViewModel, TControlValue> To<TViewModel>(TViewModel viewModel)
        {
            return new ViewModelBinding<TViewModel, TControlValue>(_control, _controlPropertyName, viewModel);
        }
    }
}