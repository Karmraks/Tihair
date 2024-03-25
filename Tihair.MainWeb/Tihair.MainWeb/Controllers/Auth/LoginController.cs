using Microsoft.AspNetCore.Mvc;

namespace Tihair.MainWeb.Controllers.Auth;

[ApiController]
[Route("api/[controller]")]
public class LoginController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        return Ok("Its Login");
    }
}