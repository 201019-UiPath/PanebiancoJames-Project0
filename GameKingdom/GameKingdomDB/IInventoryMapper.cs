using models = GameKingdomDB.Models;
using entities = GameKingdomDB.Entities;
using System.Collections.Generic;

namespace GameKingdomDB
{
    public interface IInventoryMapper
    {
        models.Inventory ParseInventory (entities.Inventory inventory);

        entities.Inventory ParseInventory (models.Inventory inventory);

        List<models.Inventory> ParseInventory (ICollection<entities.Inventory> inventory);

        ICollection<entities.Inventory> ParseInventory (List<models.Inventory> inventory);
    }
}