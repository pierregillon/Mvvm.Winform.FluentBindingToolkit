using System.Windows.Forms;
using Mvvm.Winform.BindingToolkit;

namespace Examples
{
    public partial class SimpleForm : Form
    {
        public SimpleForm()
        {
            InitializeComponent();

            var viewModel = new SimpleFormViewModel();

            txtbxFirstName
                .Bind(x => x.Text)
                .To(viewModel)
                .On(x => x.FirstName)
                .TwoWay();

            numYearsOld
                .Bind(x => x.Value)
                .To(viewModel)
                .On(x => x.YearsOld)
                .TwoWay();

            labelFormattedFirstName
                .Bind(x => x.Text)
                .To(viewModel)
                .On(x => x.YearsOld)
                .OneWay()
                .UseFormat("Your age is 0 !");

            saveButton.Command = viewModel.SaveCommand;
        }
    }
}
