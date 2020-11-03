using System;
using GameKingdomDB;
using GameKingdomDB.Models;
using GameKingdomLib;
using System.Collections.Generic;

namespace GameKingdomUI
{
    public class ManagerMenu : IMenu
    {
        private string userInput;

        private IManagerRepo repo;

        private IMessagingService service;

        private ManagerService managerService;
        
        public ManagerMenu(IManagerRepo repo, IMessagingService service)
        {
            this.repo = repo;
            this.service = service;
            this.managerService = new ManagerService(repo);
        }

        public void Start()
        {
            do
            {
                Console.WriteLine("\nWelcome Manager! What would you like to do?");
                Console.WriteLine("[0] Signup?");
                Console.WriteLine("[1] Login?");
                Console.WriteLine("[2] Go back to the main menu?");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        //call create a Manager, get Manager details
                        Manager newManager = GetManagerDetails();
                        //call the business logic and the repo
                        repo.AddAManager(newManager);
                        break;
                    case "1":
                        //call login   
                                        
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

        public Manager GetManagerDetails()
        {
            Manager manager = new Manager();
            Console.Write("\nEnter Your Name: ");
            manager.Name = Console.ReadLine();
            Console.Write("Enter Your Password: ");
            manager.Password = Console.ReadLine();
            return manager;
        }
    }
}