using System;
using GameKingdomDB;
using GameKingdomDB.Models;
using GameKingdomLib;
using System.Collections.Generic;

namespace GameKingdomUI
{
    public class CustomerMenu : IMenu
    {
        private string userInput;

        private ICustomerRepo repo;

        private IMessagingService service;

        private CustomerService customerService;
        
        public CustomerMenu(ICustomerRepo repo, IMessagingService service)
        {
            this.repo = repo;
            this.service = service;
            this.customerService = new CustomerService(repo);
        }

        public void Start()
        {
            do
            {
                Console.WriteLine("Welcome Customer! What would you like to do?");
                Console.WriteLine("[0] Signup?");
                Console.WriteLine("[1] Login?");
                Console.WriteLine("[2] Go back to the main menu?");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        //call create a customer, get customer details
                        Customer newCustomer = GetCustomerDetails();
                        //call the business logic and the repo
                        repo.AddACustomer(newCustomer);
                        break;
                    case "1":
                        //call login   
                                        
                        break;
                    case "2":
                        Console.WriteLine("Going back to main");
                        break;
                    default:
                        //invalid input message;
                        service.InvalidInputMessage();
                        break;
                }
            } while (!userInput.Equals("2"));
        }

        public Customer GetCustomerDetails()
        {
            Customer customer = new Customer();
            Console.Write("Enter Your Name: ");
            customer.Name = Console.ReadLine();
            Console.Write("Enter Your Address: ");
            customer.Address = Console.ReadLine();
            Console.Write("Enter Your Password: ");
            customer.Password = Console.ReadLine();
            return customer;
        }
    }
}