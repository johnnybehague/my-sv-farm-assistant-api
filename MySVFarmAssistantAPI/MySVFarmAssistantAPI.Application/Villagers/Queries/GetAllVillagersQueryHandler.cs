using MediatR;
using MySVFarmAssistantAPI.Application.Villagers.DTO;
using MySVFarmAssistantAPI.Domain.Villagers.Entities;
using MySVFarmAssistantAPI.Domain.Villagers.Interfaces;

namespace MySVFarmAssistantAPI.Application.Villagers.Queries;

public class GetAllVillagersQueryHandler : IRequestHandler<GetAllVillagersQuery, IEnumerable<VillagerDto>>
{
    private readonly IVillagerRepository _repository;

    public GetAllVillagersQueryHandler(IVillagerRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<VillagerDto>> Handle(GetAllVillagersQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.GetAllAsync(cancellationToken);
        var dtos = entities.Select(x => GetDtoFromEntity(x)).ToList();
        return dtos;
    }

    private VillagerDto GetDtoFromEntity(Villager entity)
    {
        return new VillagerDto
        {
            Id = entity.Id,
            Name = entity.Name,
        };
    }
}
