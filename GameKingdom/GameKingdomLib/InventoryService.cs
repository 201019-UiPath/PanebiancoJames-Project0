using GameKingdomDB.Models;
using GameKingdomDB;
using System.Collections.Generic;
using System;
using Serilog;

namespace GameKingdomLib
{
    public class InventoryService
    {
        private IInventoryRepo repo;

        public InventoryService(IInventoryRepo repo)
        {
            this.repo = repo;
        }

        public void AddToInventory(Inventory newInventoryItem)
        {
            repo.AddToInventory(newInventoryItem);
        }

        public void UpdateInventory(Inventory inventoryItem)
        {
            repo.UpdateInventory(inventoryItem);
        }

        public Inventory GetInventoryById(int id)
        {
            return repo.GetInventoryById(id);
        }

        public Inventory GetInventoryByLocationId(int id)
        {
            return repo.GetInventoryByLocationId(id);
        }

        public Inventory GetProductByLocationAndProductId(int locationId, int productId)
        {
            return repo.GetProductByLocationAndProductId(locationId, productId);
        }

        public List<Inventory> GetInventoriesById(int id)
        {
            return repo.GetInventoriesById(id);
        }

        public List<Inventory> GetInventoriesByLocationId(int id)
        {
            return repo.GetInventoriesByLocationId(id);
        }
    }
}