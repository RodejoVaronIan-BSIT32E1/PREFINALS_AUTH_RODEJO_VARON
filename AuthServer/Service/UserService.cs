using AuthServer.Model;
using AuthServer.Core.Repositories;
using AuthServer.Core.Service;
using System.Threading.Tasks;


namespace AuthServer.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepositories _userRepository;

        public UserServices(IUserRepositories userRepository)
        {
            _userRepository = userRepository;
        }

    }
}


