using Examples.Mvvms;
using ICommand = System.Windows.Input.ICommand;

namespace Examples
{
    public class SimpleFormViewModel : ViewModelBase
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        private int _yearsOld;
        public int YearsOld
        {
            get { return _yearsOld; }
            set
            {
                _yearsOld = value;
                OnPropertyChanged();
            }
        }

        private Gender? _gender;
        public Gender? Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                OnPropertyChanged();
            }
        }

        private bool _isVisible;
        public bool IsVisible
        {
            get { return _isVisible; }
            set
            {
                _isVisible = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; }

        public SimpleFormViewModel()
        {
            SaveCommand = new RelayCommand(Save, CanSave);
        }

        private bool CanSave()
        {
            return string.IsNullOrEmpty(FirstName) == false &&
                   YearsOld > 0 &&
                   Gender.HasValue;
        }
        private void Save()
        {
            IsVisible = false;
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}