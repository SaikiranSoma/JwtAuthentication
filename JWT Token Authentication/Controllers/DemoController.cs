using JWT_Token_Authentication.Model;
using JWT_Token_Authentication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Token_Authentication.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [Authorize(Roles = UserRoles.User)]
        [HttpGet("User")]
        public IActionResult HelloUser()
        {
            return Ok("Hello User");
        }

        [Authorize(Roles = UserRoles.Admin)]
        [HttpGet("Admin")]
        public IActionResult HelloAdmin()
        {
            return Ok("Hello Admin");
        }
    }
}
