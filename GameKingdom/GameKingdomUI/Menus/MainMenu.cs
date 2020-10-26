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
        // ManagerBL managerBL = new ManagerBL();

        public void Start()
        {
            string userInput;
            do {
                Console.WriteLine("[0] Get Order History \n[1] Choose A Location  \n[2] Exit");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        
                        break;
                    case "1":
                        
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

    }
}