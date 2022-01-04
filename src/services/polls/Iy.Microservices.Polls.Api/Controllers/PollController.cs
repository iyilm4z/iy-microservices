using Microsoft.AspNetCore.Mvc;

namespace Iy.Microservices.Polls.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PollController : ControllerBase
{
    [HttpGet("ping")]
    public string Index()
    {
        return "Pool api works!";
    }
}