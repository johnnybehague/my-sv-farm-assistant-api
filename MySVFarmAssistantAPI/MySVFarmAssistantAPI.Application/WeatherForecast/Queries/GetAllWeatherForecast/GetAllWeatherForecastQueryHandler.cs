using MediatR;
using MySVFarmAssistantAPI.Application.WeatherForecast.DTO;
using MySVFarmAssistantAPI.Domain.WeatherForecast.Interfaces;

namespace MySVFarmAssistantAPI.Application.WeatherForecast.Queries.GetAllWeatherForecast;

public class GetAllWeatherForecastQueryHandler : IRequestHandler<GetAllWeatherForecastQuery, IEnumerable<WeatherForecastItemDto>>
{
    private readonly IWeatherForecastRepository _repository;
    private readonly IWeatherForecastFactory _factory;

    public GetAllWeatherForecastQueryHandler(IWeatherForecastRepository repository, IWeatherForecastFactory factory)
    {
        _repository = repository;
        _factory = factory;
    }

    public async Task<IEnumerable<WeatherForecastItemDto>> Handle(GetAllWeatherForecastQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.GetAllAsync(cancellationToken);
        var dtos = entities.Select(x =>new WeatherForecastItemDto
        {
            Date = x.Date,
            Summary = x.Summary,
            TemperatureC = x.Temperature
        }).ToList();
        return dtos;
    }
}
