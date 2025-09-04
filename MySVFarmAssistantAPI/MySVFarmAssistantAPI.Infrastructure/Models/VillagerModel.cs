using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySVFarmAssistantAPI.Infrastructure.Models;

[Table("Villagers")]
public class VillagerModel
{
    [Key]
    public int Id { get; set; }

    [Column("Name")]
    public string Name { get; set; }
}
