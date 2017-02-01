using System.ComponentModel;
using System.Runtime.CompilerServices;
using Examples.Mvvms;
using ICommand = System.Windows.Input.ICommand;

namespace Examples
{
    public class SimpleFormViewModel : INotifyPropertyChanged
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
        public ICommand SaveCommand { get; }

        public SimpleFormViewModel()
        {
            SaveCommand = new RelayCommand(Save, CanSave);
        }

        private bool CanSave()
        {
            return string.IsNullOrEmpty(FirstName) == false && YearsOld > 0;
        }
        private void Save() {}

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}