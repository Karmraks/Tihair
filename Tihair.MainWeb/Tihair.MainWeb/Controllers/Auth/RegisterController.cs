using Microsoft.AspNetCore.Mvc;

namespace Tihair.MainWeb.Controllers.Auth;

[ApiController]
[Route("api/[controller]")]
public class RegisterController : Controller
{
    [HttpGet]
    public IActionResult Register()
    {
        return Ok("Its Register");
    }
}