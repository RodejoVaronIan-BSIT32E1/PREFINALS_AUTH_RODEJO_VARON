using AuthServer.Model;
using System.Threading.Tasks;

namespace AuthServer.Core.Repositories
{
    public interface IUserRepositories
    {
        Task<User> GetUserAsync(string username);
        Task<bool> AddUserAsync(User user);
    }
}

