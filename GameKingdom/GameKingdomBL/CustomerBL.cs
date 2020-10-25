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

        public void AddCustomer(Customer newCustomer)
        {
            repo.AddCustomerAsync(newCustomer);
        }

        public List<Customer> GetAllCustomers()
        {
            Task<List<Customer>> getCustomers = repo.GetAllCustomersAsync();
            return getCustomers.Result;
        }

        
    }
}
