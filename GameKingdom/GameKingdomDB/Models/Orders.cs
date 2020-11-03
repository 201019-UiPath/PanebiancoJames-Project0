using System;
using System.Collections.Generic;

namespace GameKingdomDB.Models
{
    /// <summary>
    /// Orders Class
    /// </summary>
    public class Orders
    {
        public int Id {get; set;}

        public int CustomerId {get; set;}

        public int LocationId {get; set;}

        public int ProductId {get; set;}

        public DateTime OrderDate {get; set;}

        public double Cost {get; set;}

    }
}