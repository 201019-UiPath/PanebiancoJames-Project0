using models = GameKingdomDB.Models;
using entities = GameKingdomDB.Entities;
using System.Collections.Generic;

namespace GameKingdomDB
{
    public interface ICustomerMapper
    {

        models.Customer ParseCustomer (entities.Customer customer);

        entities.Customer ParseCustomer (models.Customer customer);

        List<models.Customer> ParseCustomer (ICollection<entities.Customer> customers);

        ICollection<entities.Customer> ParseCustomer (List<models.Customer> customers);
    }
}