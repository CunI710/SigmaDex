using Core.Models.BaseModels;

namespace Core.Abstractions.Repositories
{
    public interface ISigmaTypeRepository
    {
        Task<bool> Create(SigmaType sigmaType);
        Task<bool> Delete(int id);
        Task<List<SigmaType>> Get();
        Task<SigmaType> GetById(int id);
        Task<List<SigmaType>> GetAllByIds(List<int> ids);
    }
}