using Xunit;
using entities = GameKingdomDB.Entities;
using models = GameKingdomDB.Models;
using GameKingdomDB.Mappers;
using GameKingdomDB.Repos;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GameKingdomTest.GameKingdomDBTest
{
    public class DBRepoTest
    {
        private readonly IMapper mapper = new DBMapper();

        private DBRepo repo;

        // Test data

        private readonly models.Customer testCustomer = new models.Customer()
        {
            Name = "John",
            Password = "helloPassword",
            Address = "322 NY"
        };

        private readonly List<entities.Customer> testCustomers = new List<entities.Customer>()
        {
            new entities.Customer()
            {
                Name = "Larry",
                Password = "iamLarry",
                Address = "071 CA"
            },
            new entities.Customer()
            {
                Name = "Bob",
                Password = "aReallyLongPassword",
                Address = "638 FL"
            }
        };

        private readonly List<entities.Manager> testManagers = new List<entities.Manager>()
        {
            new entities.Manager()
            {
                Name = "Steve",
                Password = "iamLarry",
                Locationid = 1
            },
            new entities.Manager()
            {
                Name = "Eric",
                Password = "aReallyLongPassword",
                Locationid = 2
            }
        };

        private readonly List<entities.Location> locations = new List<entities.Location>()
        {
            new entities.Location() 
            {
                State = "FL",
                City = "Orlando",
                Street = "S Orlando St"
            },
            new entities.Location() 
            {
                State = "NV",
                City = "Los Vegas",
                Street = "N 34th St"
            }
        };

        private readonly List<entities.Product> products = new List<entities.Product>()
        {
            new entities.Product() 
            {
                Gamename = "Dark Souls",
                Price = 25
            },
            new entities.Product() 
            {
                Gamename = "Dragon Age",
                Price = 50
            }
        };

        private readonly List<entities.Inventory> inventories = new List<entities.Inventory>()
        {
            new entities.Inventory() 
            {
                Quantity = 75,
                Productid = 1,
                Locationid = 1
            },
            new entities.Inventory() 
            {
                Quantity = 30,
                Productid = 2,
                Locationid = 2
            }
        };

        private readonly List<entities.Orders> orders = new List<entities.Orders>()
        {
            new entities.Orders() 
            {
                //Date = 
                Cost = 25,
                Customerid = 1,
                Locationid = 1
            },
            new entities.Orders() 
            {
                //Date = "9/4/2020",
                Cost = 50,
                Customerid = 2,
                Locationid = 2
            }
        };

        private void Seed(entities.GameKingdomContext testcontext)
        {
            testcontext.Customer.AddRange(testCustomers);
            testcontext.Location.AddRange(locations);
            testcontext.Product.AddRange(products);
            testcontext.Manager.AddRange(testManagers);
            testcontext.Orders.AddRange(orders);
            testcontext.Inventory.AddRange(inventories);
            testcontext.SaveChanges();
        }

        [Fact]
        public void AddCustomerShouldAdd()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<entities.GameKingdomContext>().UseInMemoryDatabase("AddCustomerShouldAdd").Options;
            using var testcontext = new entities.GameKingdomContext(options);
            repo = new DBRepo(testcontext, mapper);

            // Act
            repo.AddACustomer(testCustomer);

            // Assert
            using var assertContext = new entities.GameKingdomContext(options);
            Assert.NotNull(assertContext.Customer.Single(c => c.Name == testCustomer.Name));
        }

        [Fact]
        public void GetCustomerShouldGetCustomer()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<entities.GameKingdomContext>().UseInMemoryDatabase("GetCustomerShouldGetCustomer").Options;
            using var testcontext = new entities.GameKingdomContext(options);
            Seed(testcontext);

            // Act
            using var assertContext = new entities.GameKingdomContext(options);
            repo = new DBRepo(assertContext, mapper);
            var result = repo.SignInCustomer("Larry", "iamLarry");

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Larry", result.Name);
            Assert.Equal("iamLarry", result.Password);
        }
    }
}