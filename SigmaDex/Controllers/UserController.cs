using Core.Abstractions.Services;
using Core.Models.Query.Requests.User;
using Microsoft.AspNetCore.Mvc;

namespace SigmaDex.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase{
        private readonly IUserService service;

        public UserController(IUserService service) {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll() {
            (var response, string error) = await service.GetUsers();
            return Ok(response);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id) {
            (var response, string error) = await service.GetUserById(id);
            if (response != null) 
                return Ok(response);
            return BadRequest(error);
        }

        [HttpPost]
        public async Task<ActionResult> Create(UserCreateRequest request) {
            (var response, string error) = await service.CreateUser(request);
            if (response)
                return Ok();
            return BadRequest(error);
        }
        [HttpPut]
        public async Task<ActionResult> Update(UserUpdateRequest request) {
            (var response, string error) = await service.UpdateUser(request);
            if (response)
                return Ok();
            return BadRequest(error);
        }
        [HttpPut("password")]
        public async Task<ActionResult> UpdatePassword(UserUpdatePasswordRequest request) {
            (var response, string error) = await service.UpdatePassword(request);
            if (response)
                return Ok();
            return BadRequest(error);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id) {
            (var response, string error) = await service.DeleteUser(id);
            if (response)
                return Ok();
            return BadRequest(error);
        }
    }
}
