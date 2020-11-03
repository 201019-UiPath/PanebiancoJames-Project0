using models = GameKingdomDB.Models;
using entities = GameKingdomDB.Entities;

namespace GameKingdomDB
{
    public interface IManagerMapper
    {

        models.Manager ParseManager (entities.Manager manager);

        entities.Manager ParseManager (models.Manager manager);

    }
}