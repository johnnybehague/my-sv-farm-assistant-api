using MySVFarmAssistantAPI.Domain.WeatherForecast.Entities;
using MySVFarmAssistantAPI.Infrastructure.Models;

namespace MySVFarmAssistantAPI.Infrastructure.WeatherForecast.Extensions;

public static class WeatherForecastItemExtensions
{
    public static WeatherForecastItem ToEntity(this WeatherForecastItemModel model)
    {
        if (model == null)
            throw new ArgumentNullException(nameof(model));

        return new WeatherForecastItem
        {
            // Inherited Properties
            Id = model.Id,
            Temperature = model.Temperature,
            Date = DateOnly.Parse(model.Date),
            Summary = model.Summary
        };
    }
}
