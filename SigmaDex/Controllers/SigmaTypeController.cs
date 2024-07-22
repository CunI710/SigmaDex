using Core.Abstractions.Services;
using Core.Models.Query.Requests.Sigma;
using Core.Models.Query.Requests.Sigmatype;
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
        public async Task<ActionResult> Create(SigmaTypeCreateRequest request) {
            return Ok(await service.CreateSigmaType(request));
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id) {
            return Ok(await service.DeleteSigmaType(id));
        }
    }
}
