using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SecureApiJwtAuth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProtectedController : ControllerBase
    {
        [HttpGet("public")]
        public IActionResult Public()
        {
            return Ok("This is a public endpoint.");
        }

        [Authorize]
        [HttpGet("secure")]
        public IActionResult Secure()
        {
            var username = User.Identity?.Name ?? "Unknown";
            return Ok($"Welcome, {username}. You’ve accessed a protected route!");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("admin")]
        public IActionResult AdminOnly()
        {
            return Ok("You are an admin!");
        }
    }
}