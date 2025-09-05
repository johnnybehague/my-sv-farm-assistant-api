using MediatR;
using MySVFarmAssistantAPI.Application.Villagers.DTO;

namespace MySVFarmAssistantAPI.Application.Villagers.Queries.GetVillagerById;

public record GetVillagerByIdQuery : IRequest<VillagerDto>
{
    public int Id { get; set; }
}
