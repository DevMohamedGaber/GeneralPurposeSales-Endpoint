using GeneralPurposeSalesAppEndpoint.Services.Interfaces;
using GeneralPurposeSalesAppEndpoint.Types;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace GeneralPurposeSalesAppEndpoint.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private IUserService userService;
    public AuthController(IUserService userService)
    {
        this.userService = userService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginCredentials credentials)
    {
        return Ok(credentials);
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] CreateUserRequest req)
    {

        var result = await userService.Register(req);

        return result.isSuccess ? Ok(result) : BadRequest(result);
    }
}
