using Core.Abstractions.Services;
using Core.Models.Query.Requests.Sigma;
using Core.Models.Query.Responses.Sigma;
using Microsoft.AspNetCore.Mvc;

namespace SigmaDex.Controllers; 
[ApiController]
[Route("api/[controller]")]
public class SigmaController : ControllerBase {
    private readonly ISigmaService service;

    public SigmaController(ISigmaService service) {
        this.service = service;
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> GetInfoById(int id) {
        return Ok(await service.GetSigmaInfoById(id));
    }
    [HttpGet("example/{id:int}")]
    public async Task<ActionResult> GetExampleById(int id) {
        return Ok(await service.GetSigmaExampleById(id));
    }
    [HttpGet]
    public async Task<ActionResult> GetInfo() {
        return Ok(await service.GetSigmaInfos());
    }
    [HttpGet("example")]
    public async Task<ActionResult> GetExample() {
        return Ok(await service.GetSigmaExamples());
    }

    [HttpPost]
    public async Task<ActionResult> Create(SigmaCreateRequest request) {
        return Ok(await service.CreateSigma(request));
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id) {
        return Ok(await service.DeleteSigma(id));
    }
}
