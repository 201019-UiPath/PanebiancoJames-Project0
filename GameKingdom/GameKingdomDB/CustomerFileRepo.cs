using System.Collections.Generic;
using GameKingdomLib;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GameKingdomDB
{
    /// <summary>
    /// Repository using files
    /// </summary>
    public class CustomerFileRepo : ICustomerRepository
    {
        string filepath = @"C:\Revature_Workspace\PanebiancoJames-Project0\GameKingdom\GameKingdomDB\CustomerDataPlace\Customers.txt";

        /// <summary>
        /// Adds customer to file
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public async void AddCustomerAsync(Customer customer)
        {
            using(FileStream fs = File.Create(filepath)){
                await JsonSerializer.SerializeAsync(fs, customer);
                // Test code to see if it ran.
                System.Console.WriteLine("Customer is being written to file");
            }
        }

        /// <summary>
        /// Gets all customers from file
        /// </summary>
        /// <returns></returns>
        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            List<Customer> allCustomers = new List<Customer>();
            using(FileStream fs = File.OpenRead(filepath))
            {
                allCustomers.Add(await JsonSerializer.DeserializeAsync<Customer>(fs));
            }
            return allCustomers;
        }
    }
}
