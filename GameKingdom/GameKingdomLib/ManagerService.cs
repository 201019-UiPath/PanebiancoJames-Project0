using GameKingdomDB.Models;
using GameKingdomDB.Repos;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace GameKingdomLib
{
    public class ManagerService
    {
        private IManagerRepo repo;

        public ManagerService(IManagerRepo repo)
        {
            this.repo = repo;
        }

        public void AddManager(Manager newManager)
        {
            repo.AddAManager(newManager);
        }
    }
}