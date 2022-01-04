using Microsoft.AspNetCore.Mvc;

namespace Iy.Microservices.News.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NewsController : ControllerBase
{
    [HttpGet("ping")]
    public string Index()
    {
        return "News api works!";
    }
}