using GameKingdomLib;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameKingdomDB
{
    /// <summary>
    /// Data access interface for Orders
    /// </summary>
    public interface IOrdersRepository
    { 
         /// <summary>
         /// Adds order to data storage place
         /// </summary>
         /// <param name="orders"></param>
         void AddOrderAsync(Orders orders);

         /// <summary>
         /// Gets all orders from data storage place
         /// </summary>
         /// <returns></returns>
         Task<List<Orders>> GetAllOrdersAsync();

    }
}