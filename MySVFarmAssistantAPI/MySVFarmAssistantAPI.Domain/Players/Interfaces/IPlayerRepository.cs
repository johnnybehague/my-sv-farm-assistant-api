using MySVFarmAssistantAPI.Domain.Players.Entities;

namespace MySVFarmAssistantAPI.Domain.Players.Interfaces;

public interface IPlayerRepository
{
    public Task<Player> GetByIdAsync(int id, CancellationToken cancellationToken = default);
}
