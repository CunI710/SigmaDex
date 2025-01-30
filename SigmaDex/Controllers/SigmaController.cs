using Core.Abstractions.Services;
using Core.Enums.OptionEnums;
using Core.Models.Query.Requests.Sigma;
using Core.Models.Query.Responses.Sigma;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(nameof(Permission.CreateSigma))]
    public async Task<ActionResult> Create(SigmaCreateRequest request) {
        return Ok(await service.CreateSigma(request));
    }
    [HttpDelete("{id:int}")]
    [Authorize(nameof(Permission.DeleteSigma))]
    public async Task<ActionResult> Delete(int id) {
        return Ok(await service.DeleteSigma(id));
    }
    [HttpPut]
    [Authorize(nameof(Permission.UpdateSigma))]
    public async Task<ActionResult> Edit(SigmaUpdateRequest request) {
        return Ok(await service.EditSigma(request));
    }
}
