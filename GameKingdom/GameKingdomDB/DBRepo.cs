using System.Collections.Generic;
using System.Threading.Tasks;
using GameKingdomDB.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GameKingdomDB
{
    public class DBRepo : ICustomerRepo
    {
        private GameKingdomContext context;

        public DBRepo(GameKingdomContext context)
        {
            this.context = context;
        }

        public void AddACustomerAsync(Customer customer)
        {
            context.Customers.AddAsync(customer);
            context.SaveChangesAsync();
        }
    }
}