using GameKingdomDB.Models;
using System.Collections.Generic;

namespace GameKingdomDB
{
    public interface ILocationRepo
    {
        void AddLocation(Location location);

        Location GetLocationById(int id);

        List<Location> GetAllLocations();
    }
}