using GameKingdomDB.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameKingdomDB
{
    public interface ICustomerRepo
    {
        void AddACustomer(Customer customer);
    }
}