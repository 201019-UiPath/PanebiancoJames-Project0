namespace GameKingdomDB.Mappers
{
    public interface IManagerMapper
    {

        Models.Manager ParseManager (Entities.Manager manager);

        Entities.Manager ParseManager (Models.Manager manager);

    }
}