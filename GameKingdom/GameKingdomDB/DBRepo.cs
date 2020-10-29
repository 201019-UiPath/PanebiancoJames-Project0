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
        public void AddACustomer(Customer customer)
        {
            context.People.Add(mapper.ParseCustomer(customer));
            context.SaveChanges();
        }

        public void AddAManager(Manager manager)
        {
            context.People.Add(mapper.ParseManager(manager));
            context.SaveChanges();
        }
    }
}