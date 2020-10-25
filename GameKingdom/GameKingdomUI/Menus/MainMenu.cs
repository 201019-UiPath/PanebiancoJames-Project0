using System;
using GameKingdomLib;
using GameKingdomBL;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace GameKingdomUI.Menus
{
    public class MainMenu : IMenu
    {
        CustomerBL customerBL = new CustomerBL();

        public void Start()
        {
            string userInput;
            do{
                Console.WriteLine("Welcome to GameKingdom! What would you like to do today?");
                Console.WriteLine("[0] Create ID \n[1] Get all IDs \n[2] Exit");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        Customer newCustomer = GetCustomerDetails();
                        customerBL.AddCustomer(newCustomer);
                        Console.WriteLine($"Customer {newCustomer.CustomerId} was created");
                        break;
                    case "1":
                        List<Customer> allCustomers = customerBL.GetAllCustomers();
                        foreach(var customer in allCustomers)
                        {
                            Console.WriteLine($"Customer {customer.CustomerId}");
                        }
                        break;
                    case "2":
                        System.Console.WriteLine("Goodbye Customer");
                        break;
                    default:
                        System.Console.WriteLine("Invalid input! Please select a valid option!");
                        break;
                }
            } while (!userInput.Equals("2"));
        }

        public Customer GetCustomerDetails()
        {
            Customer customer = new Customer();
            do{
                Console.WriteLine("Enter Customer ID: ");
                customer.CustomerId = Console.ReadLine();
                
            }while(Regex.IsMatch(customer.CustomerId, "[\\d]"));
            
            Console.WriteLine("Customer Created!"); // use logging software to log this
            //add step that pushes this hero's details to the BL
            return customer;
            
        }
    }
}