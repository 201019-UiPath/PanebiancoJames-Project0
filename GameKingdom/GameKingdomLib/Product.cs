using System;

namespace GameKingdomLib
{
    public class Product
    {

        /// <summary>
        /// Auto Prop for ProductId
        /// </summary>
        /// <value></value>
        private int ProductId {get; set;}

        /// <summary>
        /// Auto Prop for ProductCost
        /// </summary>
        /// <value></value>
        private int ProcutCost{get; set;}

        public Product(int productId, int productCost)
        {
            ProductId = productId;
            ProcutCost = productCost;
        }
    }
}