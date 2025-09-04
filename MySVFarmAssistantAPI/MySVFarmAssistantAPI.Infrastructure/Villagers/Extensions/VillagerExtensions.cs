using MySVFarmAssistantAPI.Domain.Villagers.Entities;
using MySVFarmAssistantAPI.Domain.WeatherForecast.Entities;
using MySVFarmAssistantAPI.Infrastructure.Models;

namespace MySVFarmAssistantAPI.Infrastructure.Villagers.Extensions;

public static class VillagerExtensions
{
    public static Villager ToEntity(this VillagerModel model)
    {
        if (model == null)
            throw new ArgumentNullException(nameof(model));

        return new Villager
        {
            Id = model.Id,
            Name = model.Name,
            Sex = model.Sex,
            Marriage = model.Marriage == "Y",
            Birthday = model.Birthday,
            LivesIn = model.LivesIn,
            Address = model.Address,
            ClinicVisit = model.ClinicVisit
        };
    }
}
