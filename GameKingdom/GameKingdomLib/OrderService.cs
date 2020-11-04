using GameKingdomDB.Models;
using GameKingdomDB;
using System.Collections.Generic;
using System;
using Serilog;

namespace GameKingdomLib
{
    public class OrderService
    {
        private IOrderRepo repo;

        public OrderService(IOrderRepo repo)
        {
            this.repo = repo;
        }

        public void AddOrder(Orders newOrder)
        {
            repo.AddOrder(newOrder);
        }

        public Orders GetOrdersById(int id)
        {
            return repo.GetOrdersById(id);
        }
        
        public Orders GetOrdersByCustomerId(int id)
        {
            return repo.GetOrdersByCustomerId(id);
        }

        public Orders GetOrdersByLocationId(int id)
        {
            return repo.GetOrdersByLocationId(id);
        }

        public Orders GetOrdersByDate(DateTime date)
        {
            return repo.GetOrdersByDate(date);
        }

        public List<Orders> GetAllOrdersByCustomerId(int id)
        {
            return repo.GetAllOrdersByCustomerId(id);
        }

        public List<Orders> GetAllOrdersByLocationId(int id)
        {
            return repo.GetAllOrdersByLocationId(id);
        }
    }
}