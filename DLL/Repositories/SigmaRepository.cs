using AutoMapper;
using Core.Abstractions.Repositories;
using Core.Models.BaseModels;
using DataAccess.Entities;
using DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

public class SigmaRepository : ISigmaRepository
{
    private readonly IMapper mapper;
    private readonly SigmaDbContext context;

    public SigmaRepository(IMapper mapper, SigmaDbContext context)
    {
        this.mapper = mapper;
        this.context = context;
    }

    public async Task<Sigma> GetById(int id)
    {
        var sigmaEntity = await context.Sigmas
            .Include(s => s.Types)
            .Include(s => s.Weaknesses)
            .Include(s => s.NextStep)
            .Include(s => s.PrevStep)
            .Include(s => s.AllEvolution)
            .FirstOrDefaultAsync(s => s.Id == id);
        var sigma = mapper.Map<Sigma>(sigmaEntity);
        return sigma;
    }
    public async Task<List<Sigma>> GetAllByIds(List<int> ids)
    {
        var sigmaEntity = await context.Sigmas
            .Include(s => s.Types)
            .Include(s => s.Weaknesses)
            .Include(s => s.NextStep)
            .Include(s => s.PrevStep)
            .Include(s => s.AllEvolution)
            .Where(s => ids.Contains(s.Id)).ToListAsync();
        var sigma = mapper.Map<List<Sigma>>(sigmaEntity);
        return sigma;
    }
    public async Task<List<Sigma>> GetAll()
    {
        var sigmaEntities = await context.Sigmas
            .Include(s => s.Types)
            .Include(s => s.Weaknesses)
            .Include(s => s.NextStep)
            .Include(s => s.PrevStep)
            .Include(s => s.AllEvolution)
            .ToListAsync();
        var sigmas = mapper.Map<List<Sigma>>(sigmaEntities);
        return sigmas;
    }
    public async Task<bool> Delete(int id)
    {
        var sigmaEntity = await context.Sigmas.FirstOrDefaultAsync(s => s.Id == id);
        if (sigmaEntity == null)
        {
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

        sigmaEntity.Types = await context.SigmaTypes
            .Where(t => sigma.TypeIds.Contains(t.Id))
            .ToListAsync();
        sigmaEntity.Weaknesses = await context.SigmaTypes
            .Where(t => sigma.WeaknesseIds!.Contains(t.Id))
            .ToListAsync();

        sigmaEntity.PrevStep = await context.Sigmas
            .Include(s => s.AllEvolution)!
            .ThenInclude(s => s.AllEvolution)
            .FirstOrDefaultAsync(s => s.Id == sigma.PrevStepId);
        sigmaEntity.NextStep = await context.Sigmas
            .Include(s => s.AllEvolution)!
            .ThenInclude(s => s.AllEvolution)
            .FirstOrDefaultAsync(s => s.Id == sigma.NextStepId);

        List<SigmaEntity> allEvo = new();

        if (sigmaEntity.PrevStep != null) {
            allEvo.AddRange(sigmaEntity.PrevStep.AllEvolution!);
            sigmaEntity.PrevStep.NextStep = sigmaEntity;
        }
        allEvo.Add(sigmaEntity);
        if (sigmaEntity.NextStep != null) {
            allEvo.AddRange(sigmaEntity.NextStep.AllEvolution!);
            sigmaEntity.NextStep.PrevStep = sigmaEntity;
        }


        foreach (var s in allEvo) {
            s.AllEvolution = allEvo;
        }

        await context.Sigmas.AddAsync(sigmaEntity);
        await context.SaveChangesAsync();
        return true;
    }
    public async Task<bool> Update(Sigma sigma) {
        var sigmaEntity = await context.Sigmas
            .Include(s => s.Types)
            .Include(s => s.Weaknesses)
            .Include(s => s.NextStep)
            .Include(s => s.PrevStep)
            .Include(s => s.AllEvolution)
            .FirstOrDefaultAsync(s => s.Id == sigma.Id);

        if (sigmaEntity == null) {
            return false;
        }

        sigmaEntity.Name = sigma.Name;
        sigmaEntity.Description = sigma.Description;
        sigmaEntity.ImageUrl = sigma.ImageUrl;
        sigmaEntity.AverageHeight = sigma.AverageHeight;
        sigmaEntity.AverageWeight = sigma.AverageWeight;
        sigmaEntity.Testosterone = sigma.Testosterone;
        sigmaEntity.EvolutionLevel = sigma.EvolutionLevel;

        sigmaEntity.Types = await context.SigmaTypes
            .Where(t => sigma.TypeIds.Contains(t.Id))
            .ToListAsync();
        sigmaEntity.Weaknesses = await context.SigmaTypes
            .Where(t => sigma.WeaknesseIds!.Contains(t.Id))
            .ToListAsync();

        sigmaEntity.PrevStep = await context.Sigmas
            .Include(s => s.AllEvolution)!
            .ThenInclude(s => s.AllEvolution)
            .FirstOrDefaultAsync(s => s.Id == sigma.PrevStepId);
        sigmaEntity.NextStep = await context.Sigmas
            .Include(s => s.AllEvolution)!
            .ThenInclude(s => s.AllEvolution)
            .FirstOrDefaultAsync(s => s.Id == sigma.NextStepId);

        List<SigmaEntity> allEvo = new();

        if (sigmaEntity.PrevStep != null) {
            allEvo.AddRange(sigmaEntity.PrevStep.AllEvolution!);
            sigmaEntity.PrevStep.NextStep = sigmaEntity;
        }
        allEvo.Add(sigmaEntity);
        if (sigmaEntity.NextStep != null) {
            allEvo.AddRange(sigmaEntity.NextStep.AllEvolution!);
            sigmaEntity.NextStep.PrevStep = sigmaEntity;
        }


        foreach (var s in allEvo) {
            s.AllEvolution = allEvo;
        }

        await context.SaveChangesAsync();
        return true;
    }
}
