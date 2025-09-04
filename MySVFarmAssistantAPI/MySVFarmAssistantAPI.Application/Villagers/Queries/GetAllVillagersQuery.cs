using MediatR;
using MySVFarmAssistantAPI.Application.Villagers.DTO;

namespace MySVFarmAssistantAPI.Application.Villagers.Queries;

public record GetAllVillagersQuery : IRequest<IEnumerable<VillagerDto>>
{

}
