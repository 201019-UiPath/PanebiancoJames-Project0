using GameKingdomDB.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameKingdomDB
{
    public interface IManagerRepo
    {
        void AddAManager(Manager manager);
    }
}