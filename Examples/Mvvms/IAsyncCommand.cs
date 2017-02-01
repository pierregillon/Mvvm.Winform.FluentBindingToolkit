using System.Threading.Tasks;

namespace Examples.Mvvms
{
    public interface IAsyncCommand
    {
        Task ExecuteAsync();
        bool CanExecute();
    }
}