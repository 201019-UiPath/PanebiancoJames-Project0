using System;

namespace GameKingdomLib
{
    /// <summary>
    /// Customer model
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Automatic Property for CustomerId
        /// </summary>
        /// <value></value>
        private int CustomerId {get; set; }

        /// <summary>
        /// Customer constructor
        /// </summary>
        /// <param name="customerId"></param>
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
    }
}