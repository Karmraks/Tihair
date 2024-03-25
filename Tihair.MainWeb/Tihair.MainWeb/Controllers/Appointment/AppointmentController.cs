using Microsoft.AspNetCore.Mvc;

namespace Tihair.MainWeb.Controllers.Appointment;

[ApiController]
[Route("api/[controller]")]
public class AppointmentController : Controller
{
    [HttpGet]
    public IActionResult GetAppointments()
    {
        return Ok("HomePage is here");
    }
}