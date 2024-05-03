using Microsoft.AspNetCore.Mvc;
using static AuthServer.Core.Service.IUserServices;
using AuthServer.Core.Service;

namespace AuthServer.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAuthService _authService;

        public AuthController(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(string username, string password)
        {
            if (await _userService.RegisterAsync(username, password))
                return Ok();

            return BadRequest();
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(string username, string password)
        {
            var token = await _userService.AuthenticateAsync(username, password);
            if (token != null)
                return Ok(new { Token = token });

            return Unauthorized();
        }
    }
}

