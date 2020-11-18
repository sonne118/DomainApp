using System.Threading.Tasks;

namespace App.Domain.Core
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}
