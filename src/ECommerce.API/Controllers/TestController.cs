using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Test ()
    {
        throw new Exception("Error Occured");
    }
}
