using System;

namespace GameKingdomLib
{
    /// <summary>
    /// Customer business code
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Automatic Property for Customer Id
        /// </summary>
        /// <value></value>
        private int CustomerId {get; set; }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
    }
}