namespace Examples.Mvvms
{
    public interface ICommand
    {
        void Execute();
        bool CanExecute();
    }
}