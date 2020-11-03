using GameKingdomDB.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using GameKingdomDB.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GameKingdomDB
{
    public class DBRepo : ICustomerRepo, IManagerRepo
    {
        private readonly GameKingdomContext context;

        private readonly IMapper mapper;
        
        public DBRepo(GameKingdomContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public void AddACustomer(Models.Customer customer)
        {
            context.Customer.Add(mapper.ParseCustomer(customer));
            context.SaveChanges();
        }

        public Models.Customer GetACustomer(string name, string password)
        {
            return mapper.ParseCustomer(context.Customer.First(x => x.Name == name && x.Password == password));
        }

        public void AddAManager(Models.Manager manager)
        {
            context.Manager.Add(mapper.ParseManager(manager));
            context.SaveChanges();
        }

    }
}