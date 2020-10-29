using System;
using GameKingdomDB;
using GameKingdomDB.Entities;
using GameKingdomLib;

namespace GameKingdomUI
{
    public class MainMenu : IMenu
    {
        // stores user input
        private string userInput;

        private CustomerMenu customerMenu;

        private ManagerMenu managerMenu;

        private IMessagingService service;
   
        public MainMenu(GameKingdomContext context, IMapper mapper, IMessagingService service)
        {
            this.customerMenu = new CustomerMenu(new DBRepo(context, mapper), new MessagingService());
            this.managerMenu = new ManagerMenu(new DBRepo(context, mapper), new MessagingService());
            this.service = service;
        }
        
        public void Start()
        {
            do{
                Console.WriteLine("Welcome to GameKingdom! Are you a Customer or a Manager?");
                Console.WriteLine("[0] Customer?");
                Console.WriteLine("[1] Manager?");
                Console.WriteLine("[2] Exit?");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        //call the customer menu;
                        customerMenu.Start();
                        break;
                    case "1":
                        //call the manager menu;
                        managerMenu.Start();
                        break;
                    case "2":
                        Console.WriteLine("Have a good day!");
                        break;
                    default:
                        //call the invalid message
                        service.InvalidInputMessage();
                        break;
                }

            }while(!(userInput.Equals("2")));
        }
    }
}