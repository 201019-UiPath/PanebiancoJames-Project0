using System;
using GameKingdomDB;
using models = GameKingdomDB.Models;
using entities = GameKingdomDB.Entities;
using GameKingdomLib;
using System.Collections.Generic;
using Serilog;

namespace GameKingdomUI
{
    public class LocationMenu : IMenu
    {
        private string userInput;

        private ILocationRepo repo;

        private IMessagingService service;

        private LocationService locationService;

        private entities.GameKingdomContext context;

        private IMapper mapper;

        public LocationMenu(entities.GameKingdomContext context, IMapper mapper, ILocationRepo repo, IMessagingService service)
        {
            this.repo = repo;
            this.service = service;
            this.locationService = new LocationService(repo);
        }
        
        public void Start()
        {
            do{
                Console.WriteLine("\nPlease choose a Location");
                List<models.Location> locations = locationService.GetAllLocations();
                foreach(var l in locations)
                {
                    Console.WriteLine($"Id: {l.Id}\t State: {l.State}, City: {l.City}, Street: {l.Street}");
                }
                Console.WriteLine("Press [3] to go back to Main Menu");
                userInput = Console.ReadLine();
                switch(userInput)
                {
                    case "1":
                        // Order Menu
                        Log.Information($"User Chose Location Id: {userInput}");
                        break;
                    case "2":
                        // Order Menu
                        Log.Information($"User Chose Location Id: {userInput}");
                        break;
                    case "3":
                        Log.Information("Back to Customer Menu");
                        service.BackToMainMenuMessage();
                        break;
                    default:
                        Log.Information($"Invalid Input Main Menu: {userInput}");
                        service.InvalidInputMessage();
                        break;
                }
            } while(!userInput.Equals("3"));
        }
    }
}