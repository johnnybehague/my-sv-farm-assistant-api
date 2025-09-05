using Microsoft.EntityFrameworkCore;
using MySVFarmAssistantAPI.Domain.Players.Entities;
using MySVFarmAssistantAPI.Domain.Players.Interfaces;
using MySVFarmAssistantAPI.Infrastructure.Persistence;
using MySVFarmAssistantAPI.Infrastructure.Players.Extensions;

namespace MySVFarmAssistantAPI.Infrastructure.Players.Repositories;

public class PlayerRepository : IPlayerRepository
{
    private readonly AppDbContext _context;

    public PlayerRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Player> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var data = await _context.Players.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        return data.ToEntity();
    }
}
