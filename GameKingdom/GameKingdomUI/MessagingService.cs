using System;

namespace GameKingdomUI
{
    public class MessagingService : IMessagingService
    {
        public void InvalidInputMessage()
        {
            Console.WriteLine("Invalid input! Please choose a valid option.");
        }
    }
}