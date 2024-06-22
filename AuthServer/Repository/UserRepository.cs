using AuthServer.Core.Repositories;
using AuthServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer.Repositories
{
    public class UserRepositories : IUserRepositories
    {
        private readonly List<User> _users;

        public UserRepositories()
        {
            _users = new List<User>();
        }

        public Task<User> GetUserAsync(string username)
        {
            var user = _users.FirstOrDefault(u => u.Username == username);
            return Task.FromResult(user);
        }

        public Task<bool> AddUserAsync(User user)
        {
            try
            {
                _users.Add(user);
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                return Task.FromResult(false);
            }
        }
    }
}
