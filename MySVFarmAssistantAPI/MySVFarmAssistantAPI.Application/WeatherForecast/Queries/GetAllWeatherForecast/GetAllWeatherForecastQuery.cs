using MediatR;
using MySVFarmAssistantAPI.Application.WeatherForecast.DTO;

namespace MySVFarmAssistantAPI.Application.WeatherForecast.Queries.GetAllWeatherForecast;

public record GetAllWeatherForecastQuery : IRequest<IEnumerable<WeatherForecastItemDto>>
{

}
