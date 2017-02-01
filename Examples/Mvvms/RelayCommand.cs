using System;
using System.Diagnostics;

namespace Examples.Mvvms
{
    public class RelayCommand : System.Windows.Input.ICommand, ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action execute)
            : this(execute, null)
        {
        }
        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException(nameof(execute));

            _execute = execute;
            _canExecute = canExecute;
        }

        public void Execute()
        {
            if (CanExecute()) {
                _execute();
            }
        }
        public bool CanExecute()
        {
            return _canExecute == null || _canExecute();
        }

        [DebuggerStepThrough]
        bool System.Windows.Input.ICommand.CanExecute(object parameter)
        {
            return CanExecute();
        }
        void System.Windows.Input.ICommand.Execute(object parameter)
        {
            Execute();
        }
    }

    public class RelayCommand<T> : System.Windows.Input.ICommand
    {
        private readonly Action<T> _execute;
        private readonly Predicate<T> _canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<T> execute)
            : this(execute, null)
        {
        }
        public RelayCommand(Action<T> execute, Predicate<T> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException(nameof(execute));

            _execute = execute;
            _canExecute = canExecute;
        }

        [DebuggerStepThrough]
        public bool CanExecute(T parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }
        public void Execute(T parameter)
        {
            _execute(parameter);
        }

        [DebuggerStepThrough]
        bool System.Windows.Input.ICommand.CanExecute(object parameter)
        {
            return CanExecute((T) parameter);
        }
        void System.Windows.Input.ICommand.Execute(object parameter)
        {
            Execute((T) parameter);
        }
    }
}