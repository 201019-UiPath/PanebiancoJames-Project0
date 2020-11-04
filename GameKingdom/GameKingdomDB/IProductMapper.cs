using models = GameKingdomDB.Models;
using entities = GameKingdomDB.Entities;
using System.Collections.Generic;

namespace GameKingdomDB
{
    public interface IProductMapper
    {
        models.Product ParseProduct (entities.Product product);

        entities.Product ParseProduct (models.Product product);

        List<models.Product> ParseProduct (ICollection<entities.Product> product);

        ICollection<entities.Product> ParseProduct (List<models.Product> product);
    }
}