using models = GameKingdomDB.Models;
using entities = GameKingdomDB.Entities;

namespace GameKingdomDB
{
    public interface ICustomerMapper
    {

        models.Customer ParseCustomer (entities.Customer customer);

        entities.Customer ParseCustomer (models.Customer customer);

    }
}