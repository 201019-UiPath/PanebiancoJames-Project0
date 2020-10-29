using GameKingdomDB.Models;
using GameKingdomDB.Entities;

namespace GameKingdomDB
{
    public interface ICustomerMapper
    {

        Customer ParseCustomer (People customer);

        People ParseCustomer (Customer customer);
    }
}