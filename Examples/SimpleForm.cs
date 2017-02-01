using System.Windows.Forms;
using Examples.Converters;
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

            labelNumberInLetters
                .Bind(x => x.Text)
                .To(viewModel)
                .On(x => x.YearsOld)
                .OneWay()
                .UseConverter(new NumberInLettersConverter());

            rbtnMale
                .Bind(x => x.Checked)
                .To(viewModel)
                .On(x => x.Gender)
                .TwoWay()
                .UseConverter(new EnumToBooleanConverter<Gender>(Gender.Male));

            rbtnFemale
                .Bind(x => x.Checked)
                .To(viewModel)
                .On(x => x.Gender)
                .TwoWay()
                .UseConverter(new EnumToBooleanConverter<Gender>(Gender.Female));

            saveButton.Command = viewModel.SaveCommand;
        }
    }
}