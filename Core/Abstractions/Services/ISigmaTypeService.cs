using Core.Models.Query.Requests.Sigmatype;
using Core.Models.Query.Responses;

namespace Core.Abstractions.Services {
    public interface ISigmaTypeService {
        Task<bool> CreateSigmaType(SigmaTypeCreateRequest request);
        Task<bool> DeleteSigmaType(int id);
        Task<bool> EditSigmaType(SigmaTypeUpdateRequest request);
        Task<SigmaTypeInfoResponse> GetSigmaTypeById(int id);
        Task<List<SigmaTypeInfoResponse>> GetSigmaTypes();
    }
}