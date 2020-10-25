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
        public string CustomerId {get; set; }

        /// <summary>
        /// Customer constructor with ID
        /// </summary>
        /// <param name="customerId"></param>
        public Customer(string customerId)
        {
            CustomerId = customerId;
        }

        public Customer()
        {
            
        }
    }
}