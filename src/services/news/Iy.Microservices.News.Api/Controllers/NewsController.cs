using Microsoft.AspNetCore.Mvc;

namespace Iy.Microservices.News.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class NewsController : ControllerBase
{
    [HttpGet(Name = "ping")]
    public string Index()
    {
        return "News api works!";
    }
}