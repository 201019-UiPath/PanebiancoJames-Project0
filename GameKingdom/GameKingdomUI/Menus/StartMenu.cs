using System;
using GameKingdomLib;
using GameKingdomBL;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace GameKingdomUI.Menus
{
    /// <summary>
    /// Start menu that shows up first when project is run
    /// </summary>
    public class StartMenu : IMenu
    {
        CustomerBL customerBL = new CustomerBL();
        public void Start()
        {
            string userInput;
            do 
            {
                Console.WriteLine("Welcome to GameKingdom");
                Console.WriteLine("[0] Login \n[1] Sign Up \n[2] Exit");
                userInput = Console.ReadLine();
                switch(userInput) 
                {
                    // User logs in
                    case "0":
                        Customer customerDetials = GetCustomerDetails();
                        List<Customer> allCustomers = customerBL.GetAllCustomers();
                        foreach(var customer in allCustomers)
                        {
                            if (customerDetials.Equals(customer.CustomerId))
                            {
                                IMenu mainMenu = new MainMenu();
                                mainMenu.Start();
                                break;
                            }
                        }
                        break;
                    case "1":
                        Customer newCustomer = GetCustomerDetails();
                        customerBL.AddCustomer(newCustomer);
                        System.Console.WriteLine($"Customer {newCustomer.CustomerId} was created.");
                        break;
                    case "2":
                        Console.WriteLine("Thanks for stopping bye!");
                        break;
                    default:
                        Console.WriteLine("Invalid input! Please select a valid option!");
                        break;
                }
            } while(!userInput.Equals("2"));
        }

        /// <summary>
        /// Gets the users detials
        /// </summary>
        /// <returns></returns>
        public Customer GetCustomerDetails()
        {
            Customer customer = new Customer();
            do{
                Console.WriteLine("Enter Customer ID: ");
                customer.CustomerId = Console.ReadLine();
                
            }while(Regex.IsMatch(customer.CustomerId, "[\\d]"));
            
            return customer;           
        }
    }
}