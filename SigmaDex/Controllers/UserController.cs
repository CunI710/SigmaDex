using Core.Abstractions.Services;
using Core.Enums.OptionEnums;
using Core.Models.Query.Requests.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace SigmaDex.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase {
        private readonly IUserService service;

        public UserController(IUserService service) {
            this.service = service;
        }

        [HttpGet]
        [Authorize(nameof(Permission.ReadUser))]
        public async Task<ActionResult> GetAll() {
            (var response, string error) = await service.GetUsers();
            return Ok(response);
        }
        [HttpGet("{id:int}")]
        [Authorize(nameof(Permission.ReadUser))]
        public async Task<ActionResult> GetById(int id)
        {
            (var response, string error) = await service.GetUserById(id);
            if (response != null)
                return Ok(response);
            return BadRequest(error);
        }

        [HttpGet("info")]
        [Authorize]
        public async Task<ActionResult> GetByClaim()
        {

            var authHeader = HttpContext.Request.Headers["Authorization"].FirstOrDefault();
            var jwt = authHeader?.Split(' ').Last();
            var jsonToken = new JwtSecurityTokenHandler().ReadToken(jwt) as JwtSecurityToken;
            int id = Convert.ToInt32(jsonToken!.Payload["userId"]);


            (var response, string error) = await service.GetUserById(id);
            if (response != null)
                return Ok(response);
            return BadRequest(error);
        }

        [HttpPost]
        [Authorize(nameof(Permission.CreateUser))]
        public async Task<ActionResult> Create(UserCreateRequest request) {
            (var response, string error) = await service.CreateUser(request);
            if (response)
                return Ok();
            return BadRequest(error);
        }
        [HttpPut]
        [Authorize(nameof(Permission.UpdateUser))]
        public async Task<ActionResult> Update(UserUpdateRequest request) {
            (var response, string error) = await service.UpdateUser(request);
            if (response)
                return Ok();
            return BadRequest(error);
        }
        [HttpPut("password")]
        [Authorize]
        public async Task<ActionResult> UpdatePassword(UserUpdatePasswordRequest request) {
            (var response, string error) = await service.UpdatePassword(request);
            if (response)
                return Ok();
            return BadRequest(error);
        }

        [HttpDelete]
        [Authorize(nameof(Permission.DeleteUser))]
        public async Task<ActionResult> Delete(int id) {
            (var response, string error) = await service.DeleteUser(id);
            if (response)
                return Ok();
            return BadRequest(error);
        }
    }
}
