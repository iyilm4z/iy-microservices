using Microsoft.AspNetCore.Mvc;

namespace Iy.Microservices.Polls.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PollController : ControllerBase
{
    [HttpGet(Name = "ping")]
    public string Index()
    {
        return "Pool api works!";
    }
}