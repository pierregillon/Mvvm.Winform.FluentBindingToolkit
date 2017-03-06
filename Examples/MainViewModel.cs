using Examples.Mvvms;

namespace Examples
{
    public class MainViewModel : ViewModelBase
    {
        private readonly SimpleFormViewModel _simpleViewModel;

        public ICommand ShowSimpleViewModelCommand { get; }
        public ICommand DoSomethingIfMenuEnabledCommand { get; }

        private bool _menuEnabled;
        public bool MenuEnabled
        {
            get { return _menuEnabled; }
            set
            {
                if (_menuEnabled != value)
                {
                    _menuEnabled = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainViewModel(SimpleFormViewModel simpleViewModel)
        {
            _simpleViewModel = simpleViewModel;
            ShowSimpleViewModelCommand = new RelayCommand(ShowSimpleViewModel);
            DoSomethingIfMenuEnabledCommand = new RelayCommand(() => { }, () => MenuEnabled);
        }

        private void ShowSimpleViewModel()
        {
            _simpleViewModel.IsVisible = true;
        }
    }
}
