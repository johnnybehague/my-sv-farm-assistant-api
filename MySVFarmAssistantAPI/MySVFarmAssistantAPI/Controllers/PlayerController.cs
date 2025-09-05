using MediatR;
using Microsoft.AspNetCore.Mvc;
using MySVFarmAssistantAPI.Application.Players.DTO;
using MySVFarmAssistantAPI.Application.Players.Queries.GetPlayerById;

namespace MySVFarmAssistantAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayerController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<PlayerController> _logger;

    public PlayerController(IMediator mediator, ILogger<PlayerController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpGet("{id}", Name = "GetPlayerById")]
    public async Task<ActionResult<PlayerDto>> GetById(int id, CancellationToken cancellationToken)
    {
        var query = new GetPlayerByIdQuery { Id = id };
        var items = await _mediator.Send(query, cancellationToken);
        return Ok(items);
    }
}