using MySVFarmAssistantAPI.Domain.WeatherForecast.Entities;

namespace MySVFarmAssistantAPI.Domain.WeatherForecast.Interfaces;

public interface IWeatherForecastRepository
{
    public Task<IEnumerable<WeatherForecastItem>> GetAllAsync(CancellationToken cancellationToken = default);
}
