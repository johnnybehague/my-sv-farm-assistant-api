using MySVFarmAssistantAPI.Domain.Villagers.Entities;

namespace MySVFarmAssistantAPI.Domain.Villagers.Interfaces;

public interface IVillagerRepository
{
    public Task<IEnumerable<Villager>> GetAllAsync(CancellationToken cancellationToken = default);

    public Task<Villager> GetByIdAsync(int id, CancellationToken cancellationToken = default);
}
