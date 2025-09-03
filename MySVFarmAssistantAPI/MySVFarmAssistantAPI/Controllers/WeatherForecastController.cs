using MediatR;
using Microsoft.AspNetCore.Mvc;
using MySVFarmAssistantAPI.Application.WeatherForecast.DTO;
using MySVFarmAssistantAPI.Application.WeatherForecast.Queries.GetAllWeatherForecast;

namespace MySVFarmAssistantAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IMediator mediator, ILogger<WeatherForecastController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<ActionResult<IEnumerable<WeatherForecastItemDto>>> Get(CancellationToken cancellationToken)
        {
            var query = new GetAllWeatherForecastQuery();
            var items = await _mediator.Send(query, cancellationToken);
            return Ok(items);
        }
    }
}
