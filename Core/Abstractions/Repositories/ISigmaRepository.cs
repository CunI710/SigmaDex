using Core.Models.BaseModels;

namespace Core.Abstractions.Repositories
{
    public interface ISigmaRepository
    {
        Task<bool> Create(Sigma sigma);
        Task<bool> Delete(int id);
        Task<List<Sigma>> GetAll();
        Task<List<Sigma>> GetAllByIds(List<int> ids);
        Task<Sigma> GetById(int id);
    }
}