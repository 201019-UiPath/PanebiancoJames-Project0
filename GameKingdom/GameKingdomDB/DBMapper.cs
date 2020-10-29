using GameKingdomDB.Entities;
using GameKingdomDB.Models;

namespace GameKingdomDB
{
    public class DBMapper : IMapper
    {
        public Customer ParseCustomer(People customer)
        {
            return new Customer()
            {
                Name = customer.Name,
                Address = customer.Address,
                Password = customer.Password,
                Id = customer.Id
            };
        }

        public People ParseCustomer(Customer customer)
        {
            return new People()
            {
                Name = customer.Name,
                Address = customer.Address,
                Password = customer.Password,
                Chartype = 1
            };
        }

        public Manager ParseManager(People manager)
        {
            return new Manager()
            {
                Name = manager.Name,
                Address = manager.Address,
                Password = manager.Password,
                Id = manager.Id
            };
        }

        public People ParseManager(Manager manager)
        {
            return new People()
            {
                Name = manager.Name,
                Address = manager.Address,
                Password = manager.Password,
                Chartype = 2
            };
        }
    }
}