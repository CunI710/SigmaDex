using AutoMapper;
using Core.Abstractions.Repositories;
using Core.Abstractions.Services;
using Core.Models.BaseModels;
using Core.Models.Query.Requests.Sigma;
using Core.Models.Query.Responses.Sigma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services;

public class SigmaService : ISigmaService {
    private readonly ISigmaRepository repos;
    private readonly ISigmaTypeRepository typeRepos;
    private readonly IMapper mapper;

    public SigmaService(ISigmaRepository repos, ISigmaTypeRepository typeRepos, IMapper mapper) {
        this.repos = repos;
        this.typeRepos = typeRepos;
        this.mapper = mapper;
    }

    public async Task<SigmaInfoResponse> GetSigmaInfoById(int id) {
        var sigma = await repos.GetById(id);
        var response = mapper.Map<SigmaInfoResponse>(sigma);
        return response;
    }
    public async Task<List<SigmaInfoResponse>> GetSigmaInfos() {
        var sigma = await repos.GetAll();
        var response = mapper.Map<List<SigmaInfoResponse>>(sigma);
        return response;
    }
    public async Task<SigmaExampleResponse> GetSigmaExampleById(int id) {
        var sigma = await repos.GetById(id);
        var response = mapper.Map<SigmaExampleResponse>(sigma);
        return response;
    }
    public async Task<List<SigmaExampleResponse>> GetSigmaExamples() {
        var sigma = await repos.GetAll();
        var response = mapper.Map<List<SigmaExampleResponse>>(sigma);
        return response;
    }
    public async Task<bool> DeleteSigma(int id) {
        return await repos.Delete(id);
    }
    public async Task<bool> CreateSigma(SigmaCreateRequest request) {
        var sigma = mapper.Map<Sigma>(request);
        return await repos.Create(sigma);
    }
    public async Task<bool> EditSigma(SigmaUpdateRequest request) {
        var sigma = await repos.GetById(1);
        return true;
    }

}
