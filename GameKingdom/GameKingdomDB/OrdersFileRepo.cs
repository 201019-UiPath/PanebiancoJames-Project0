using System.Collections.Generic;
using GameKingdomLib;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GameKingdomDB
{
    /// <summary>
    /// Repository using files
    /// </summary>
    public class OrdersFileRepo : IOrdersRepository
    {
        string filepath = @"C:\Revature_Workspace\PanebiancoJames-Project0\GameKingdom\GameKingdomDB\OrdersDataPlace\Orders.txt";

        /// <summary>
        /// Adds order to file
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        public async void AddOrderAsync(Orders orders)
        {
            using(FileStream fs = File.Create(filepath)){
                await JsonSerializer.SerializeAsync(fs, orders);
            }
        }

        /// <summary>
        /// Gets all orders from file
        /// </summary>
        /// <returns></returns>
        public async Task<List<Orders>> GetAllOrdersAsync()
        {
            List<Orders> allOrders = new List<Orders>();
            using(FileStream fs = File.OpenRead(filepath))
            {
                allOrders.Add(await JsonSerializer.DeserializeAsync<Orders>(fs));
            }
            return allOrders;
        }
    }
}