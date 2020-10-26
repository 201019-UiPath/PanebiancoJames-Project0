using System;
using GameKingdomLib;
using GameKingdomDB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameKingdomBL
{
    public class CustomerBL
    {
        ICustomerRepository repo = new CustomerFileRepo();

        /// <summary>
        /// Adds a customer to the repo
        /// /// </summary>
        /// <param name="newCustomer"></param>
        public void AddCustomer(Customer newCustomer)
        {
            repo.AddCustomerAsync(newCustomer);
        }

        /// <summary>
        /// Gets a list of all customers from the repo
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetAllCustomers()
        {
            Task<List<Customer>> getCustomers = repo.GetAllCustomersAsync();
            return getCustomers.Result;
        }

        
    }
}
