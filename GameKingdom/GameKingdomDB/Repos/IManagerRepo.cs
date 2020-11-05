using GameKingdomDB.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameKingdomDB.Repos
{
    public interface IManagerRepo
    {
        void AddAManager(Manager manager);
    }
}