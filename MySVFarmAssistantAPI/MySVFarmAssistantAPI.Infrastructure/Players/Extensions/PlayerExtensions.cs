using MySVFarmAssistantAPI.Domain.Players.Entities;
using MySVFarmAssistantAPI.Infrastructure.Models;

namespace MySVFarmAssistantAPI.Infrastructure.Players.Extensions;

public static class PlayerExtensions
{
    public static Player ToEntity(this PlayerModel model)
    {
        if (model == null)
            throw new ArgumentNullException(nameof(model));

        return new Player
        {
            Id = model.Id,
            Name = model.Name,
            FarmName = model.FarmName,
            Gender = model.Gender
        };
    }
}
