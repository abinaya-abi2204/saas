using Microsoft.AspNetCore.Mvc;
using SupportAnalyticsAPI.Models;
using SupportAnalyticsAPI.Services;

namespace SupportAnalyticsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        JwtService jwt=new JwtService();

        [HttpPost("login")]
        public IActionResult Login(User login)
        {
            if(login.Username=="admin" && login.Password=="admin")
            {
                var token=jwt.Generate(login);
                return Ok(new {token});
            }

            return Unauthorized();
        }
    }
}