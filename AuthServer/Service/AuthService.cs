using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AuthServer.Core.Service;
using Microsoft.IdentityModel.Tokens;

namespace AuthServer.Services
{
    public class AuthService : IAuthService
    {
        public string GenerateJwtToken(string username)
        {
            throw new NotImplementedException();
        }
    }
}
