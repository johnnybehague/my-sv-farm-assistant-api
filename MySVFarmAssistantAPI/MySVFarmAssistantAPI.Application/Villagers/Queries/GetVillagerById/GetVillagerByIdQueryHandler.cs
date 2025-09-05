using MediatR;
using MySVFarmAssistantAPI.Application.Villagers.DTO;
using MySVFarmAssistantAPI.Domain.Villagers.Entities;
using MySVFarmAssistantAPI.Domain.Villagers.Interfaces;

namespace MySVFarmAssistantAPI.Application.Villagers.Queries.GetVillagerById;

public class GetVillagerByIdQueryHandler : IRequestHandler<GetVillagerByIdQuery, VillagerDto>
{
    private readonly IVillagerRepository _repository;

    public GetVillagerByIdQueryHandler(IVillagerRepository repository)
    {
        _repository = repository;
    }

    public async Task<VillagerDto> Handle(GetVillagerByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByIdAsync(request.Id, cancellationToken);
        var dto = GetDtoFromEntity(entity);
        return dto;
    }

    private VillagerDto GetDtoFromEntity(Villager entity)
    {
        return new VillagerDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Sex = entity.Sex,
            Marriage = entity.Marriage,
            Birthday = entity.Birthday,
            LivesIn = entity.LivesIn,
            Address = entity.Address,
            ClinicVisit = entity.ClinicVisit,
        };
    }
}
