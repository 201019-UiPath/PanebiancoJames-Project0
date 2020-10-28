namespace GameKingdomDB.Models
{
    public class User
    {
        public int Id { get; set;}

        public int CustomerId { get; set;}

        public Customer Customer { get; set;}
    }
}