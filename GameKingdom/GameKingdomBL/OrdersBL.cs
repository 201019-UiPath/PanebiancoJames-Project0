using System;
using GameKingdomLib;
using GameKingdomDB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameKingdomBL
{
    public class OrdersBL
    {
        
        IOrdersRepository repo = new OrdersFileRepo();

        public void AddOrder(Orders newOrder)
        {
            repo.AddOrderAsync(newOrder);
        }

        public List<Orders> GetAllOrders()
        {
            Task<List<Orders>> getOrders = repo.GetAllOrdersAsync();
            return getOrders.Result;
        }

    }
}