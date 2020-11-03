using GameKingdomDB.Entities;
using GameKingdomDB.Models;

namespace GameKingdomDB
{
    public class DBMapper : IMapper
    {
        public Models.Customer ParseCustomer(Entities.Customer customer)
        {
            return new Models.Customer() {
                Name = customer.Name,
                Password = customer.Password,
                Address = customer.Address,
                Id = customer.Id
            };
        }

        public Entities.Customer ParseCustomer(Models.Customer customer)
        {
            return new Entities.Customer() {
                Name = customer.Name,
                Password = customer.Password,
                Address = customer.Address,
                Id = customer.Id
            };
        }

        public Models.Manager ParseManager(Entities.Manager manager)
        {
            return new Models.Manager() {
                Name = manager.Name,
                Password = manager.Password,
                LocationId = (int) manager.Locationid,
                Id = manager.Id
            };
        }

        public Entities.Manager ParseManager(Models.Manager manager)
        {
            return new Entities.Manager() {
                Name = manager.Name,
                Password = manager.Password,
                Locationid = manager.LocationId,
                Id = manager.Id
            };
        }
    }
}