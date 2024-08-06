using JWT_Token_Authentication.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace JWT_Token_Authentication.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly List<string> _strings;

        public DemoController() => _strings = [];

        [Authorize(Roles = UserRoles.Admin)]
		[Authorize(Roles = UserRoles.User)]
        [HttpGet("GetStrings")]
        public IActionResult GetAllStrings() => Ok(_strings);

		[Authorize(Roles = UserRoles.Admin)]
		[HttpPost("AddString/{str}")]
        public IActionResult CreateProducts([FromRoute] string str)
        {
            _strings.Add(str);
            return Ok("String Added Succesfully");
        }
    }
}
