using GameKingdomDB.Models;
using System.Collections.Generic;

namespace GameKingdomDB
{
    public interface IInventoryRepo
    {
        void AddToInventory(Inventory inventoryItem);

        void UpdateInventory(Inventory inventoryItem);

        Inventory GetInventoryById(int id);

        Inventory GetInventoryByLocationId(int id);

        Inventory GetProductByLocationAndProductId(int locationId, int productId);

        List<Inventory> GetInventoriesById(int id);

        List<Inventory> GetInventoriesByLocationId(int id);
    }
}