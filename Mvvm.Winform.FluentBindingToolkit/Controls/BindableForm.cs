using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Mvvm.Winform.FluentBindingToolkit.Controls
{
    public class BindableForm : Form
    {
        public BindableForm()
        {
            CreateControl(this);
        }
       
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = true;
            Hide();
        }

        private static void CreateControl(Control control)
        {
            var method = control.GetType().GetMethod("CreateControl", BindingFlags.Instance | BindingFlags.NonPublic);
            var parameters = method.GetParameters();
            Debug.Assert(parameters.Length == 1, "Looking only for the method with a single parameter");
            Debug.Assert(parameters[0].ParameterType == typeof(bool), "Single parameter is not of type boolean");

            method.Invoke(control, new object[] { true });
        }

    }
}