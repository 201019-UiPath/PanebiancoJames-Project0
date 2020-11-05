using System;
using GameKingdomDB;
using models = GameKingdomDB.Models;
using GameKingdomDB.Entities;
using GameKingdomDB.Mappers;
using GameKingdomDB.Repos;
using GameKingdomLib;
using System.Collections.Generic;
using Serilog;

namespace GameKingdomUI
{
    public class LocationMenu : IMenu
    {
        private string userInputLocation;

        private LocationService locationService;
        private InventoryService inventoryService;
        private OrderService orderService;
        private ProductService productService;
        //private CustomerService customerService;
        

        private models.Product selectedProduct;

        private models.Customer customer;

        private IMessagingService service;

        private DateTime date = DateTime.Now;


        public LocationMenu(models.Customer customer, ILocationRepo locationRepo, IMessagingService service)
        {
            this.customer = customer;
            this.service = service;


            this.locationService = new LocationService(locationRepo);
            this.inventoryService = new InventoryService((IInventoryRepo) locationRepo);
            this.orderService = new OrderService((IOrderRepo) locationRepo);
            this.productService = new ProductService((IProductRepo) locationRepo);
            //this.customerService = new CustomerService((ICustomerRepo) locationRepo);
        }
        
        public void Start()
        {
            do{
                Console.WriteLine("\nPlease choose a Location");
                List<models.Location> locations = locationService.GetAllLocations();
                foreach(var l in locations)
                {
                    Console.WriteLine($"Index: {/*locations.IndexOf(l)*/l.Id}\t State: {l.State}, City: {l.City}, Street: {l.Street}");
                }
                Console.WriteLine("Press [3] to go back to Main Menu");
                userInputLocation = Console.ReadLine();
                switch(userInputLocation)
                {
                    case "1":
                        Log.Information($"User Chose Location Id: {userInputLocation}");
                        ChooseMenu();
                        break;
                    case "2":
                        Log.Information($"User Chose Location Id: {userInputLocation}");
                        ChooseMenu();
                        break;
                    case "3":
                        Log.Information("Back to Customer Menu");
                        service.BackToMainMenuMessage();
                        break;
                    default:
                        Log.Information($"Invalid Input Location Menu: {userInputLocation}");
                        service.InvalidInputMessage();
                        break;
                }
            } while((!userInputLocation.Equals("3")));


        }

        public void ChooseMenu()
        {
            string userInput;
            bool showMenu = true;
            do {
                Console.WriteLine("\nPlease choose what you want to do.");
                Console.WriteLine("[0] Inventory");
                userInput = Console.ReadLine();
                switch(userInput)
                {
                    case "0":
                        Log.Information("User Chose Inventory");
                        Inventory();
                        showMenu = false;
                        break;
                    default:
                        Log.Information($"Invalid Input Choosing Next Menu: {userInputLocation}");
                        service.InvalidInputMessage();
                        break;
                }
            } while (showMenu);
        }

        public void Inventory()
        {
            string inventoryInput;
            do {
                Console.WriteLine("\nSelect a Product");
                List<models.Inventory> items = inventoryService.GetInventoriesByLocationId(int.Parse(userInputLocation));
                foreach(var i in items)
                {
                    models.Product product = productService.GetProductById(i.ProductId);
                    Console.WriteLine($"Id: {product.Id}.\t Name: {product.GameName}, Price: {product.Price}, Quantity: {i.Quantity}");
                }
                Console.WriteLine("Press [0] to go back.");

                inventoryInput = Console.ReadLine();

                if (inventoryInput.Equals("0"))
                {
                    break;
                }

                selectedProduct = productService.GetProductById(int.Parse(inventoryInput));

                Console.WriteLine($"{selectedProduct.GameName}");
                Log.Information($"User Chose Item: {selectedProduct.GameName}");

                NewOrder();
                
                Log.Information("User Made Order");

            } while (!inventoryInput.Equals("0"));
        }

        public void NewOrder()
        {
            models.Orders orders = new models.Orders();
            orders.CustomerId = customer.Id;
            orders.LocationId = int.Parse(userInputLocation);
            orders.ProductId = selectedProduct.Id;
            orders.Cost = selectedProduct.Price;
            orders.OrderDate = date;

            orderService.AddOrder(orders);
        }
    }
}