using System;
using GameKingdomDB;
using entities = GameKingdomDB.Entities;
using models = GameKingdomDB.Models;
using GameKingdomLib;
using System.Collections.Generic;
using Serilog;

namespace GameKingdomUI
{
    public class MainMenu : IMenu
    {
        // stores user input
        private string userInput;

        private CustomerMenu customerMenu;

        private ManagerMenu managerMenu;

        private IMessagingService service;

        private entities.GameKingdomContext context;

        private IMapper mapper;
        
   
        public MainMenu(entities.GameKingdomContext context, IMapper mapper, IMessagingService service)
        {
            this.context = context;
            this.mapper = mapper;
            this.service = service;
            this.customerMenu = new CustomerMenu(context, mapper, new DBRepo(context,mapper), new MessagingService());
            this.managerMenu = new ManagerMenu(new DBRepo(context,mapper), new MessagingService());
        }
        
        public void Start()
        {
            do{
                Console.WriteLine("\nWelcome to GameKingdom! Are you a Customer or a Manager?");
                Console.WriteLine("[0] Customer?");
                Console.WriteLine("[1] Manager?");
                Console.WriteLine("[2] Exit?");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        //call the customer menu;
                        Log.Information("Customer Menu Launched");
                        customerMenu.Start();
                        break;
                    case "1":
                        //call the manager menu;
                        Log.Information("Manager Menu Launched");
                        managerMenu.Start();
                        break;
                    case "2":
                        Log.Information("Program Exited");
                        Console.WriteLine("Have a good day!");
                        break;
                    default:
                        //call the invalid message
                        Log.Information($"Invalid Input Main Menu: {userInput}");
                        service.InvalidInputMessage();
                        break;
                }

            }while(!(userInput.Equals("2")));
        }
    }
}