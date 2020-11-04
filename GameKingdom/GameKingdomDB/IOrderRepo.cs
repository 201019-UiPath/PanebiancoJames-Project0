using GameKingdomDB.Models;
using System;
using System.Collections.Generic;

namespace GameKingdomDB
{
    public interface IOrderRepo
    {
        void AddOrder(Orders order);
        
        Orders GetOrdersById(int id);

        Orders GetOrdersByCustomerId(int id);

        Orders GetOrdersByLocationId(int id);

        Orders GetOrdersByDate(DateTime date);

        List<Orders> GetAllOrdersByCustomerId(int id);

        List<Orders> GetAllOrdersByLocationId(int id);

        /*

            Code to get Asc/Desc dates and prices

        */
    }
}