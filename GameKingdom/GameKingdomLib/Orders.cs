using System;

namespace GameKingdomLib
{
    /// <summary>
    /// Orders model
    /// </summary>
    public class Orders
    {
        /// <summary>
        /// Auto Prop for OrderId
        /// </summary>
        /// <value></value>
        public int OrderId {get; set; }

        /// <summary>
        /// Auto Prop for OrderDate
        /// </summary>
        /// <value></value>
        public DateTime OrderDate {get; set;}

        /// <summary>
        /// Orders constructor
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="orderDate"></param>
        public Orders(int orderId, DateTime orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Orders()
        {

        }

    }
}