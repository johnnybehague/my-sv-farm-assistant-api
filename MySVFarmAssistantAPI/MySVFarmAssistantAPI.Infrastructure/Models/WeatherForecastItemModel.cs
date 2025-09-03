using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySVFarmAssistantAPI.Infrastructure.Models;

[Table("WeatherForecastItems")]
public class WeatherForecastItemModel
{
    [Key]
    public int Id { get; set; }

    [Column("Date")]
    public string Date { get; set; }

    [Column("Temperature")]
    public int Temperature { get; set; }

    [Column("Summary")]
    public string? Summary { get; set; }
}
