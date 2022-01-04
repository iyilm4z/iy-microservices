using Microsoft.AspNetCore.Mvc;

namespace Iy.Microservices.Auth.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    [HttpGet("ping")]
    public string Index()
    {
        return "Auth api works!";
    }
}