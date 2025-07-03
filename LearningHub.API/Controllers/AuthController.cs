using LearningHub.BAL.Models;
using LearningHub.BAL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningHub.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> Register([FromBody] UserRegisterModel model)
        {
            var result = await _authService.RegisterAsync(model);
            if (result == "Registration successful")
                return Ok(new { message = result });
            return BadRequest(new { message = result });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginModel model)
        {
            var result = await _authService.LoginAsync(model);
            if (result == "Login successful")
                return Ok(new { message = result });
            return Unauthorized(new { message = result });
        }
    }
}
