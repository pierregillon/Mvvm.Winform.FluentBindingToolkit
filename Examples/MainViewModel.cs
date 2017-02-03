using Examples.Mvvms;

namespace Examples
{
    public class MainViewModel : ViewModelBase
    {
        private readonly SimpleFormViewModel _simpleViewModel;

        public ICommand ShowSimpleViewModelCommand { get; }

        public MainViewModel(SimpleFormViewModel simpleViewModel)
        {
            _simpleViewModel = simpleViewModel;
            ShowSimpleViewModelCommand = new RelayCommand(ShowSimpleViewModel);
        }

        private void ShowSimpleViewModel()
        {
            _simpleViewModel.IsVisible = true;
        }
    }
}
