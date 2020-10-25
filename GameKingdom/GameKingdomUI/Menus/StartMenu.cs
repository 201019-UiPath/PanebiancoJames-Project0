using System;

namespace GameKingdomUI.Menus
{
    /// <summary>
    /// Start menu that shows up first when project is run
    /// </summary>
    public class StartMenu : IMenu
    {
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
                    case "0":
                        IMenu mainMenu = new MainMenu();
                        mainMenu.Start();
                        break;
                    case "1":
                        // IMenu signUp = new SignUp();
                        // signUp.Start();
                        break;
                    case "2":
                        Console.WriteLine("Thanks for stopping bye!");
                        break;
                    default:
                        Console.WriteLine("Please enter in a valid option");
                        break;
                }
            } while(!userInput.Equals("2"));
        }
    }
}