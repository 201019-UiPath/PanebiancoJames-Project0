using GameKingdomLib;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameKingdomDB
{
    /// <summary>
    /// Data access interface for Customers
    /// </summary>
    public interface ICustomerRepository
    {
         /// <summary>
         /// Adds customer to data storage place
         /// </summary>
         /// <param name="customer"></param>
         void AddCustomerAsync(Customer customer);

         /// <summary>
         /// Gets all customers from data storage place
         /// </summary>
         /// <returns></returns>
         Task<List<Customer>> GetAllCustomersAsync();
    }
}