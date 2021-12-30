using Microsoft.AspNetCore.Mvc;

namespace Iy.Microservices.Auth.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    [HttpGet(Name = "ping")]
    public string Index()
    {
        return "Auth api works!";
    }
}