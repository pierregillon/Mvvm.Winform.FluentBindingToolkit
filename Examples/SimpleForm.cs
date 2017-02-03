using Examples.Converters;
using Mvvm.Winform.FluentBindingToolkit;
using Mvvm.Winform.FluentBindingToolkit.Controls;

namespace Examples
{
    public partial class SimpleForm : BindableForm
    {
        public SimpleFormViewModel ViewModel { get;} = new SimpleFormViewModel();

        public SimpleForm()
        {
            InitializeComponent();

            txtbxFirstName
                .Bind(x => x.Text)
                .To(ViewModel)
                .On(x => x.FirstName)
                .TwoWay();

            numYearsOld
                .Bind(x => x.Value)
                .To(ViewModel)
                .On(x => x.YearsOld)
                .TwoWay();

            labelFormattedFirstName
                .Bind(x => x.Text)
                .To(ViewModel)
                .On(x => x.YearsOld)
                .OneWay()
                .UseFormat("Your age is 0 !");

            labelNumberInLetters
                .Bind(x => x.Text)
                .To(ViewModel)
                .On(x => x.YearsOld)
                .OneWay()
                .UseConverter(new NumberInLettersConverter());

            rbtnMale
                .Bind(x => x.Checked)
                .To(ViewModel)
                .On(x => x.Gender)
                .TwoWay()
                .UseConverter(new EnumToBooleanConverter<Gender?>(Gender.Male));

            rbtnFemale
                .Bind(x => x.Checked)
                .To(ViewModel)
                .On(x => x.Gender)
                .TwoWay()
                .UseConverter(new EnumToBooleanConverter<Gender?>(Gender.Female));

            labelGenderChoosen
                .Bind(x => x.Visible)
                .To(ViewModel)
                .On(x => x.Gender)
                .OneWay()
                .UseConverter(new NotNullToBooleanConverter<Gender?>());

            this
                .Bind(x => x.Visible)
                .To(ViewModel)
                .On(x => x.IsVisible)
                .TwoWay();

            saveButton.Command = ViewModel.SaveCommand;
        }
    }
}