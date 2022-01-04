using Microsoft.AspNetCore.Mvc;

namespace Iy.Microservices.Forums.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ForumController : ControllerBase
{
    [HttpGet("ping")]
    public string Index()
    {
        return "Forums api works!";
    }
}