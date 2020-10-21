using System;

namespace GameKingdomLib
{
    public class Orders
    {
        /// <summary>
        /// Auto Prop for Order Id
        /// </summary>
        /// <value></value>
        private int OrderId {get; set; }

        /// <summary>
        /// Auto Prop for Order Date
        /// </summary>
        /// <value></value>
        private DateTime OrderDate {get; set;}

        public Orders(int orderId)
        {
            OrderId = orderId;
            OrderDate = DateTime.Now;
        }

    }
}