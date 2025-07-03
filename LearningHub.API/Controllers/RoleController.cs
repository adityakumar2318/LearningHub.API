using LearningHub.BAL.Models;
using LearningHub.BAL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningHub.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpPost("assign")]
        public async Task<IActionResult> AssignRole([FromBody] AssignRoleModel model)
        {
            var result = await _roleService.AssignRoleAsync(model);
            if (result == "Role assigned successfully")
                return Ok(new { message = result });

            return BadRequest(new { message = result });
        }
    }
}
