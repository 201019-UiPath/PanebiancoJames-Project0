using GameKingdomDB.Models;
using GameKingdomDB;
using System.Collections.Generic;
using System;
using Serilog;

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

        public List<Customer> GetAllCustomers()
        {
            return repo.GetAllCustomers();
        }

        public Customer GetCustomer(string name, string password)
        {
            List<Customer> getCustomers = repo.GetAllCustomers();
            foreach(var customer in getCustomers)
            {
                if(!(customer.Name.Equals(name)) || !(customer.Password.Equals(password)))
                {
                    Log.Error($"Invalid Login. Name: {name} Password: {password}");
                    throw new Exception("\nInvalid Name/Password. Please try again");
                }
            }
            return repo.GetACustomer(name,password);
        }

    }
}
