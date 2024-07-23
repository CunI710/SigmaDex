using AutoMapper;
using Core.Abstractions.Repositories;
using Core.Models.BaseModels;
using DataAccess.Entities;
using DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

public class SigmaRepository : ISigmaRepository {
    private readonly IMapper mapper;
    private readonly SigmaDbContext context;

    public SigmaRepository(IMapper mapper, SigmaDbContext context) {
        this.mapper = mapper;
        this.context = context;
    }

    public async Task<Sigma> GetById(int id) {
        var sigmaEntity = await context.Sigmas
            .Include(s=>s.Types)
            .Include(s=>s.Weaknesses)
            .Include(s=>s.NextStep)
            .Include(s=>s.PrevStep)
            .FirstOrDefaultAsync(s => s.Id == id);
        var sigma = mapper.Map<Sigma>(sigmaEntity);
        return sigma;
    }
    public async Task<List<Sigma>> GetAllByIds(List<int> ids) {
        var sigmaEntity = await context.Sigmas
            .Include(s => s.Types)
            .Include(s => s.Weaknesses)
            .Include(s => s.NextStep)
            .Include(s => s.PrevStep)
            .Where(s => ids.Contains(s.Id)).ToListAsync();
        var sigma = mapper.Map<List<Sigma>>(sigmaEntity);
        return sigma;
    }
    public async Task<List<Sigma>> GetAll() {
        var sigmaEntities = await context.Sigmas
            .Include(s => s.Types)
            .Include(s => s.Weaknesses)
            .Include(s => s.NextStep)
            .Include(s => s.PrevStep)
            .ToListAsync();
        var sigmas = mapper.Map<List<Sigma>>(sigmaEntities);
        return sigmas;
    }
    public async Task<bool> Delete(int id) {
        var sigmaEntity = await context.Sigmas.FirstOrDefaultAsync(s => s.Id == id);
        if (sigmaEntity == null) {
            return false;
        }
        context.Sigmas.Remove(sigmaEntity);
        context.SaveChanges();
        return true;
    }
    public async Task<bool> Create(Sigma sigma) {
        var sigmaEntity = await context.Sigmas.FirstOrDefaultAsync(s => s.Name == sigma.Name);
        if (sigmaEntity != null) {
            return false;
        }
        sigmaEntity = mapper.Map<SigmaEntity>(sigma);

        sigmaEntity.Types = await context.SigmaTypes.Where(t => sigma.TypeIds.Contains(t.Id)).ToListAsync();
        sigmaEntity.Weaknesses = await context.SigmaTypes.Where(t => sigma.WeaknesseIds!.Contains(t.Id)).ToListAsync();

        sigmaEntity.PrevStep = await context.Sigmas.FindAsync(sigma.PrevStepId ?? 0);

        sigmaEntity.NextStep = await context.Sigmas.FindAsync(sigma.NextStepId ?? 0);

        await context.Sigmas.AddAsync(sigmaEntity);
        await context.SaveChangesAsync();
        return true;
    }
}
