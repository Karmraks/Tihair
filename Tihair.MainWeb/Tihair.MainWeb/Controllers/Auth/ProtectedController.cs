using Microsoft.AspNetCore.Mvc;

namespace Tihair.MainWeb.Controllers.Auth;

[ApiController]
[Route("api/[controller]")]
public class ProtectedController : Controller
{
    [HttpGet]
    public IActionResult Check()
    {
        return Ok("Its Protected");
    }
}