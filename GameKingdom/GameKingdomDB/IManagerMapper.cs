using GameKingdomDB.Models;
using GameKingdomDB.Entities;

namespace GameKingdomDB
{
    public interface IManagerMapper
    {

        Manager ParseManager (People manager);

        People ParseManager (Manager manager);
    }
}