namespace AuthServer.Core.Service;
using System.Threading.Tasks;

public class IUserServices
{
    public interface IUserService
    {
        Task<bool> RegisterAsync(string username, string password);
        Task<string> AuthenticateAsync(string username, string password);

    }
}

