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
                Console.WriteLine("\nWelcome Customer! What would you like to do?");
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
                        //call create a customer, get customer details
                        Customer loginCustomer = GetCustomerLogin();

                        Customer existingCustomer = customerService.GetCustomer(loginCustomer.Name,loginCustomer.Password);
                        
                        Console.WriteLine($"\nCustomer Name: {existingCustomer.Name} \nCustomer Address: {existingCustomer.Address}");
                        break;
                    case "2":
                        //back to main menu message
                        service.BackToMainMenuMessage();
                        break;
                    default:
                        //invalid input message;
                        service.InvalidInputMessage();
                        break;
                }
            } while (!userInput.Equals("2"));
        }

        /// <summary>
        /// Gets user input for a new Customer
        /// </summary>
        /// <returns></returns>
        public Customer GetCustomerDetails()
        {
            Customer customer = new Customer();
            Console.Write("\nEnter Your Name: ");
            customer.Name = Console.ReadLine();
            Console.Write("Enter Your Address: ");
            customer.Address = Console.ReadLine();
            Console.Write("Enter Your Password: ");
            customer.Password = Console.ReadLine();
            return customer;
        }

        /// <summary>
        /// Gets user input for existing Customer
        /// </summary>
        /// <returns></returns>
        public Customer GetCustomerLogin()
        {
            Customer customer = new Customer();
            Console.Write("\nEnter Your Name: ");
            customer.Name = Console.ReadLine();
            Console.Write("Enter Your Password: ");
            customer.Password = Console.ReadLine();
            return customer;
        }
    }
}