using GameKingdomDB.Models;
using GameKingdomDB;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace GameKingdomLib
{
    public class CustomerService
    {
        private ICustomerRepo repo;

        public CustomerService(ICustomerRepo repo)
        {
            this.repo = repo;
        }

        public void AddCustomer(Customer newCustomer)
        {
            repo.AddACustomer(newCustomer);
        }

        public Customer GetCustomer(string name, string password)
        {
            return repo.GetACustomer(name,password);
        }

    }
}
