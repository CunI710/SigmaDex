using AutoMapper;
using Core.Abstractions.Repositories;
using Core.Abstractions.Services;
using Core.Models.BaseModels;
using Core.Models.Query.Requests.Sigmatype;
using Core.Models.Query.Responses;

namespace Application.Services;  
public class SigmaTypeService : ISigmaTypeService {

    private readonly ISigmaTypeRepository repos;
    private readonly IMapper mapper;

    public SigmaTypeService(ISigmaTypeRepository repos, IMapper mapper) {
        this.repos = repos;
        this.mapper = mapper;
    }

    public async Task<SigmaTypeInfoResponse> GetSigmaTypeById(int id) {
        var sigmaType = await repos.GetById(id);
        var response = mapper.Map<SigmaTypeInfoResponse>(sigmaType);
        return response;
    }
    public async Task<List<SigmaTypeInfoResponse>> GetSigmaTypes() {
        var sigmaType = await repos.Get();
        var response = mapper.Map<List<SigmaTypeInfoResponse>>(sigmaType);
        return response;
    }
    public async Task<bool> DeleteSigmaType(int id) {
        return await repos.Delete(id);
    }
    public async Task<bool> CreateSigmaType(SigmaTypeCreateRequest request) {
        var sigmaType = mapper.Map<SigmaType>(request);
        return await repos.Create(sigmaType);
    }
    public async Task<bool> EditSigmaType(SigmaTypeUpdateRequest request) {
        var sigma = await repos.GetById(1);
        return true;
    }
}
