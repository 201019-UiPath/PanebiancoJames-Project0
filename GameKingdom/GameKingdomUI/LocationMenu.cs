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
        private string userInputLocation;

        private ILocationRepo locationRepo;

        private IOrderRepo orderRepo;

        private IInventoryRepo inventoryRepo;

        private IProductRepo productRepo;

        private IMessagingService service;

        private LocationService locationService;

        private models.Product selectedProduct;

        private models.Customer customer;

        private entities.GameKingdomContext context;

        private IMapper mapper;

        private InventoryService inventoryService;

        private OrderService orderService;

        private ProductService productService;

        private CustomerService customerService;

        private ICustomerRepo customerRepo;

        private DateTime date = DateTime.Now;

        public LocationMenu(models.Customer customer, entities.GameKingdomContext context, IMapper mapper, ILocationRepo locationRepo,
                            IOrderRepo orderRepo, IInventoryRepo inventoryRepo, IProductRepo productRepo, ICustomerRepo customerRepo, IMessagingService service)
        {
            this.customer = customer;
            this.context = context;
            this.mapper = mapper;
            this.service = service;
            this.locationRepo = locationRepo;
            this.orderRepo = orderRepo;
            this.inventoryRepo = inventoryRepo;
            this.productRepo = productRepo;
            this.customerRepo = customerRepo;

            this.locationService = new LocationService(locationRepo);
            this.inventoryService = new InventoryService(inventoryRepo);
            this.orderService = new OrderService(orderRepo);
            this.productService = new ProductService(productRepo);
            this.customerService = new CustomerService(customerRepo);
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
                List<models.Inventory> items = inventoryService.GetInventoriesByLocationId(1);
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

                selectedProduct = productService.GetProductById(1);

                Log.Information($"User Chose Item: {selectedProduct.GameName}");

                models.Orders aOrder = NewOrder(1, selectedProduct);
                orderRepo.AddOrder(aOrder);

                Log.Information($"User Made Order: {aOrder.Id}");

                


            } while (!inventoryInput.Equals("0"));
        }

        public models.Orders NewOrder(int id, models.Product product)
        {
            models.Orders orders = new models.Orders();
            orders.CustomerId = 1;
            orders.LocationId = 1;
            orders.ProductId = id;
            orders.Cost = product.Price;
            orders.OrderDate = date;
            return orders;
        }
    }
}