using Microsoft.EntityFrameworkCore;
using MySVFarmAssistantAPI.Domain.Villagers.Entities;
using MySVFarmAssistantAPI.Domain.Villagers.Interfaces;
using MySVFarmAssistantAPI.Domain.WeatherForecast.Entities;
using MySVFarmAssistantAPI.Infrastructure.Persistence;
using MySVFarmAssistantAPI.Infrastructure.Villagers.Extensions;

namespace MySVFarmAssistantAPI.Infrastructure.Villagers.Repositories;

public class VillagerRepository : IVillagerRepository
{
    private readonly AppDbContext _context;

    public VillagerRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Villager>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var data = await _context.Villagers.Select(x => x.ToEntity()).ToListAsync(cancellationToken);
        return data;
    }
}
