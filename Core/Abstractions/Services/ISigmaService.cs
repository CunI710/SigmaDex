using Core.Models.Query.Requests.Sigma;
using Core.Models.Query.Responses.Sigma;

namespace Core.Abstractions.Services {
    public interface ISigmaService {
        Task<bool> CreateSigma(SigmaCreateRequest request);
        Task<bool> DeleteSigma(int id);
        Task<bool> EditSigma(SigmaUpdateRequest request);
        Task<SigmaExampleResponse> GetSigmaExampleById(int id);
        Task<List<SigmaExampleResponse>> GetSigmaExamples();
        Task<SigmaInfoResponse> GetSigmaInfoById(int id);
        Task<List<SigmaInfoResponse>> GetSigmaInfos();
    }
}