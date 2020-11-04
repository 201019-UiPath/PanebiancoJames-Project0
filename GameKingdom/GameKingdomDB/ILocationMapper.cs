using models = GameKingdomDB.Models;
using entities = GameKingdomDB.Entities;
using System.Collections.Generic;

namespace GameKingdomDB
{
    public interface ILocationMapper
    {
        models.Location ParseLocation (entities.Location location);

        entities.Location ParseLocation (models.Location location);

        List<models.Location> ParseLocation (ICollection<entities.Location> location);

        ICollection<entities.Location> ParseLocation (List<models.Location> location); 
    }
}