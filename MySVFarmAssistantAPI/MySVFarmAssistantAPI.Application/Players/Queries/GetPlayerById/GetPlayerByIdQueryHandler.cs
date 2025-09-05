using MediatR;
using MySVFarmAssistantAPI.Application.Players.DTO;
using MySVFarmAssistantAPI.Domain.Players.Entities;
using MySVFarmAssistantAPI.Domain.Players.Interfaces;

namespace MySVFarmAssistantAPI.Application.Players.Queries.GetPlayerById;

public class GetPlayerByIdQueryHandler : IRequestHandler<GetPlayerByIdQuery, PlayerDto>
{
    private readonly IPlayerRepository _repository;

    public GetPlayerByIdQueryHandler(IPlayerRepository repository)
    {
        _repository = repository;
    }

    public async Task<PlayerDto> Handle(GetPlayerByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByIdAsync(request.Id, cancellationToken);
        var dto = GetDtoFromEntity(entity);
        return dto;
    }

    private PlayerDto GetDtoFromEntity(Player entity)
    {
        return new PlayerDto
        {
            Id = entity.Id,
            Name = entity.Name,
            FarmName = entity.FarmName,
            Gender = entity.Gender,
        };
    }
}