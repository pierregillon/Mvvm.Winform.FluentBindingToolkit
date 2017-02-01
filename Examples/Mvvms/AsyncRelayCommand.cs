using System;
using System.Threading.Tasks;

namespace Examples.Mvvms
{
    public class AsyncRelayCommand : System.Windows.Input.ICommand, IAsyncCommand
    {
        private readonly Func<Task> _action;
        private readonly Func<bool> _predicate;

        public AsyncRelayCommand(Func<Task> action, Func<bool> predicate = null)
        {
            _action = action;
            _predicate = predicate;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public async Task ExecuteAsync()
        {
            if (CanExecute()) {
                await _action();
            }
        }
        public bool CanExecute()
        {
            return _predicate == null || _predicate();
        }

        // ----- Implement ICommand
        bool System.Windows.Input.ICommand.CanExecute(object parameter)
        {
            return CanExecute();
        }
        async void System.Windows.Input.ICommand.Execute(object parameter)
        {
            await ExecuteAsync();
        }
    }
}