namespace MySVFarmAssistantAPI.Domain.WeatherForecast.Entities;

public class WeatherForecastItem
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public int Temperature { get; set; }

    public string? Summary { get; set; }
}
