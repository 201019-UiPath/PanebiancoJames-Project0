namespace GameKingdomDB.Models
{
    /// <summary>
    /// Orderitems class
    /// </summary>
    public class OrderItems
    {
        public int Id {get; set;}

        public int OrdersId {get; set;}

        public int ProductId {get; set;}

        public int TotalItems {get; set;}
    }
}