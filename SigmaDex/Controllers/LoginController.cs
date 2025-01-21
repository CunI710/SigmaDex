using Core.Abstractions.Services;
using Core.Models.Query.Requests.User;
using Microsoft.AspNetCore.Mvc;

namespace SigmaDex.Controllers;
[ApiController]
[Route("api/[controller]")]
public class LoginController : ControllerBase {
    private readonly ILoginService service;

    public LoginController(ILoginService service) {
        this.service = service;
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login(UserLoginRequest request) {
        (bool response, string error) = await service.Login(request);

        if (response)
            return Ok();
        return BadRequest(error);
    }

    [HttpPost]
    [Route("api/register")]
    public async Task<ActionResult> Register(UserRegisterRequest request) {
        (bool response, string error) = await service.Register(request);

        if (response)
            return Ok();
        return BadRequest(error);
    }


}

