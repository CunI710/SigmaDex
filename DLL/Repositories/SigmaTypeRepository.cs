using AutoMapper;
using Core.Abstractions.Repositories;
using Core.Models.BaseModels;
using DataAccess.Entities;
using DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class SigmaTypeRepository : ISigmaTypeRepository {
        private readonly IMapper mapper;
        private readonly SigmaDbContext context;

        public SigmaTypeRepository(IMapper mapper, SigmaDbContext context) {
            this.mapper = mapper;
            this.context = context;
        }

        public async Task<SigmaType> GetById(int id) {
            var sigmaTypeEntity = await context.SigmaTypes
                .Include(t=>t.SigmaTypes)
                .FirstOrDefaultAsync(t => t.Id == id);
            var sigmaType = mapper.Map<SigmaType>(sigmaTypeEntity);
            return sigmaType;
        }
        public async Task<List<SigmaType>> GetAllByIds(List<int> ids) {
            var sigmaTypeEntity = await context.SigmaTypes.Where(s => ids.Contains(s.Id)).ToListAsync();
            var sigmaType = mapper.Map<List<SigmaType>>(sigmaTypeEntity);
            return sigmaType;
        }
        public async Task<List<SigmaType>> Get() {
            var sigmaTypeEntities = await context.SigmaTypes
                .Include(t=>t.SigmaTypes)
                .ToListAsync();
            var sigmaTypes = mapper.Map<List<SigmaType>>(sigmaTypeEntities);
            return sigmaTypes;
        }
        public async Task<bool> Delete(int id) {
            var sigmaTypeEntity = await context.SigmaTypes.FirstOrDefaultAsync(s => s.Id == id);
            if (sigmaTypeEntity == null) {
                return false;
            }
            context.SigmaTypes.Remove(sigmaTypeEntity);
            context.SaveChanges();
            return true;
        }
        public async Task<bool> Create(SigmaType sigmaType) {
            var sigmaTypeEntity = await context.SigmaTypes.FirstOrDefaultAsync(s => s.Name == sigmaType.Name);
            if (sigmaTypeEntity != null) {
                return false;
            }
            sigmaTypeEntity = mapper.Map<SigmaTypeEntity>(sigmaType);

            context.SigmaTypes.Attach(sigmaTypeEntity);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
