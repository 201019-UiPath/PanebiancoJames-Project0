using System;

namespace GameKingdomLib
{
    /// <summary>
    /// Product model
    /// </summary>
    public class Product
    {

        /// <summary>
        /// Auto Prop for ProductId
        /// </summary>
        /// <value></value>
        public int ProductId {get; set;}

        /// <summary>
        /// Auto Prop for ProductCost
        /// </summary>
        /// <value></value>
        public int ProductCost{get; set;}

        /// <summary>
        /// Product constructor
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="productCost"></param>
        public Product(int productId, int productCost)
        {
            ProductId = productId;
            ProductCost = productCost;
        }
    }
}