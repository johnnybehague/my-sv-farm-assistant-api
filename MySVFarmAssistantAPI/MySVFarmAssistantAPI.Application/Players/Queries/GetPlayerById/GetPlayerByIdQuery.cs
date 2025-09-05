using MediatR;
using MySVFarmAssistantAPI.Application.Players.DTO;

namespace MySVFarmAssistantAPI.Application.Players.Queries.GetPlayerById;

public record GetPlayerByIdQuery : IRequest<PlayerDto>
{
    public int Id { get; set; }
}
