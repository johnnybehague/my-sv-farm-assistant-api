namespace MySVFarmAssistantAPI.Application.Villagers.DTO;

public class VillagerDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Sex { get; set; } // Enum

    public bool Marriage { get; set; }

    public string Birthday { get; set; }

    public string LivesIn { get; set; }

    public string Address { get; set; }

    public string ClinicVisit { get; set; }
}
