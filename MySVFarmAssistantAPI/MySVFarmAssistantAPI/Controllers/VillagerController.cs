using MediatR;
using Microsoft.AspNetCore.Mvc;
using MySVFarmAssistantAPI.Application.Villagers.DTO;
using MySVFarmAssistantAPI.Application.Villagers.Queries;

namespace MySVFarmAssistantAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class VillagerController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<VillagerController> _logger;

    public VillagerController(IMediator mediator, ILogger<VillagerController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpGet(Name = "GetVillagers")]
    public async Task<ActionResult<IEnumerable<VillagerDto>>> Get(CancellationToken cancellationToken)
    {
        var query = new GetAllVillagersQuery();
        var items = await _mediator.Send(query, cancellationToken);
        return Ok(items);
    }
}
