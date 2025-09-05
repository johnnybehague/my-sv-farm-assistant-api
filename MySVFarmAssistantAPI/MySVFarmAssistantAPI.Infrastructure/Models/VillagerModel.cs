using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySVFarmAssistantAPI.Infrastructure.Models;

[Table("Villagers")]
public class VillagerModel
{
    [Key]
    public int Id { get; set; }

    [Column("Name")]
    public string? Name { get; set; }

    [Column("Sex")]
    public string? Sex { get; set; }

    [Column("Marriage")]
    public string? Marriage { get; set; }

    [Column("Birthday")]
    public string? Birthday { get; set; }

    [Column("LivesIn")]
    public string? LivesIn { get; set; }

    [Column("Address")]
    public string? Address { get; set; }

    [Column("ClinicVisit")]
    public string? ClinicVisit { get; set; }
}
