using System;
using GameKingdomLib;
using GameKingdomUI.Menus;

namespace GameKingdomUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu startMenu = new MainMenu();
            startMenu.Start();
            // Test the branch
            

        }
    }
}
