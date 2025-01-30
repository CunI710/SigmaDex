using Core.Abstractions.Services;
using Core.Enums.OptionEnums;
using Core.Models.Query.Requests.Sigma;
using Core.Models.Query.Requests.Sigmatype;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SigmaDex.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class SigmaTypeController : ControllerBase {
        private readonly ISigmaTypeService service;

        public SigmaTypeController(ISigmaTypeService service) {
            this.service = service;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetInfoById(int id) {
            return Ok(await service.GetSigmaTypeById(id));
        }
        [HttpGet]
        public async Task<ActionResult> GetInfo() {
            return Ok(await service.GetSigmaTypes());
        }
        [HttpPost]
        [Authorize(nameof(Permission.CreateSigma))]
        public async Task<ActionResult> Create(SigmaTypeCreateRequest request) {
            return Ok(await service.CreateSigmaType(request));
        }

        [HttpDelete("{id:int}")]
        [Authorize(nameof(Permission.DeleteSigma))]
        public async Task<ActionResult> Delete(int id) {
            return Ok(await service.DeleteSigmaType(id));
        }
    }
}
