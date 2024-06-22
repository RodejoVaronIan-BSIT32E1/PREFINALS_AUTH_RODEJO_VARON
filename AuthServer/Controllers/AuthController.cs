// AuthController.cs

using Microsoft.AspNetCore.Mvc;
using AuthServer.Core.Service;
using AuthServer.Services;

namespace AuthServer.Controllers
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

            return Ok(new { Token = "skibdisupasecrettoiletwiththerizzmasterofgyattalandonasigmamewingstreakof11monthsstreakinsideohiowiththeboys" });
        }
    }
}
