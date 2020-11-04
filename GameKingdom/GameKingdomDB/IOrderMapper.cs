using models = GameKingdomDB.Models;
using entities = GameKingdomDB.Entities;
using System.Collections.Generic;

namespace GameKingdomDB
{
    public interface IOrderMapper
    {
        models.Orders ParseOrders (entities.Orders orders);

        entities.Orders ParseOrders (models.Orders orders);

        List<models.Orders> ParseOrders (ICollection<entities.Orders> orders);

        ICollection<entities.Orders> ParseOrders (List<models.Orders> orders);
        
    }
}