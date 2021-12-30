using Microsoft.AspNetCore.Mvc;

namespace Iy.Microservices.Forums.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ForumController : ControllerBase
{
    [HttpGet(Name = "ping")]
    public string Index()
    {
        return "Forums api works!";
    }
}