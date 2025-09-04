using MediatR;
using MySVFarmAssistantAPI.Application.Villagers.DTO;

namespace MySVFarmAssistantAPI.Application.Villagers.Queries.GetAllVillagers;

public record GetAllVillagersQuery : IRequest<IEnumerable<VillagerDto>>
{

}
