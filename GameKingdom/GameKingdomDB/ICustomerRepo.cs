using GameKingdomDB.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameKingdomDB
{
    public interface ICustomerRepo
    {
        /// <summary>
        /// Adds a Customer to the DB
        /// </summary>
        /// <param name="customer"></param>
        void AddACustomer(Customer customer);

        /// <summary>
        /// Get a Customer from the DB
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Customer GetACustomer (string name, string password);
    }
}