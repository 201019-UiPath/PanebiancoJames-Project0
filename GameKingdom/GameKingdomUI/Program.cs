using System;
using GameKingdomDB.Models;
using GameKingdomDB;
using GameKingdomDB.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameKingdomUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu main = new MainMenu(new GameKingdomContext(), new DBMapper(), new MessagingService());
            main.Start();
        }
    }
}
