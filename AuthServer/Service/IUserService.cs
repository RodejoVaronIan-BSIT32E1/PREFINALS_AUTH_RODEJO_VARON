using System.Threading.Tasks;

namespace AuthServer.Services
{
    public interface IUserService
    {
        Task<bool> RegisterAsync(string username, string password);
        Task<string> AuthenticateAsync(string username, string password);
    }
}
