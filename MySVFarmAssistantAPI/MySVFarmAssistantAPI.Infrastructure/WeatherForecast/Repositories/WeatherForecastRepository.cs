using Microsoft.EntityFrameworkCore;
using MySVFarmAssistantAPI.Domain.WeatherForecast.Entities;
using MySVFarmAssistantAPI.Domain.WeatherForecast.Interfaces;
using MySVFarmAssistantAPI.Infrastructure.Persistence;
using MySVFarmAssistantAPI.Infrastructure.WeatherForecast.Extensions;

namespace MySVFarmAssistantAPI.Infrastructure.WeatherForecast.Repositories;

public class WeatherForecastRepository : IWeatherForecastRepository
{
    private readonly AppDbContext _context;

    public WeatherForecastRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<WeatherForecastItem>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var data = await _context.WeatherForecastItems.Select(x => x.ToEntity()).ToListAsync(cancellationToken);
        return data;
    }
}
