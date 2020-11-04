using System;
using GameKingdomDB;
using models = GameKingdomDB.Models;
using entities = GameKingdomDB.Entities;
using GameKingdomLib;
using System.Collections.Generic;
using Serilog;

namespace GameKingdomUI
{
    public class CustomerMenu : IMenu
    {
        private string userInput;

        private LocationMenu locationMenu;

        private models.Customer customer;

        private entities.GameKingdomContext context;
        
        private ICustomerRepo repo;

        private IMessagingService service;

        private CustomerService customerService;

        private IMapper mapper;
            
        
        public CustomerMenu(entities.GameKingdomContext context, IMapper mapper, ICustomerRepo repo, IMessagingService service)
        {
            this.context = context;
            this.mapper = mapper;
            this.repo = repo;
            this.service = service;
            
            this.customerService = new CustomerService(repo);
            this.locationMenu = new LocationMenu(customer, context, mapper, new DBRepo(context,mapper), new DBRepo(context,mapper),
                                        new DBRepo(context,mapper), new DBRepo(context,mapper), new DBRepo(context,mapper), new MessagingService());
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
                        customer = SignUp();
                        Log.Information("New Customer Created");
                        repo.AddACustomer(customer);
                        Log.Information("Moved to Location Menu");
                        locationMenu.Start(); 
                        break;
                    case "1":
                        //call create a customer, get customer details
                        models.Customer loginCustomer = SignIn();
                        try{
                            models.Customer existingCustomer = customerService.GetCustomer(loginCustomer.Name,loginCustomer.Password);
                            Console.WriteLine($"\nCustomer Name: {existingCustomer.Name} \nCustomer Address: {existingCustomer.Address}");
                        } catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            continue;
                        }
                        break;
                    case "2":
                        //back to main menu message
                        Log.Information("Back to Main Menu");
                        service.BackToMainMenuMessage();
                        break;
                    default:
                        //invalid input message;
                        Log.Information($"Invalid Input Customer Menu: {userInput}");
                        service.InvalidInputMessage();
                        break;
                }
            } while (!userInput.Equals("2"));
        }

        /// <summary>
        /// Gets user input for a new Customer
        /// </summary>
        /// <returns></returns>
        public models.Customer SignUp()
        {
            models.Customer customer = new models.Customer();

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
        public models.Customer SignIn()
        {
            models.Customer customer = new models.Customer();
            Console.Write("\nEnter Your Name: ");
            customer.Name = Console.ReadLine();
            Console.Write("Enter Your Password: ");
            customer.Password = Console.ReadLine();
            return customer;
        }

    }
}