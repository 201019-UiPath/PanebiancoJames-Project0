using System;
using System.Collections.Generic;

namespace GameKingdomLib
{
    
    /// <summary>
    /// Location model
    /// </summary>
    
    public class Location
    {
        /// <summary>
        /// Auto Prop for TotalProduct
        /// </summary>
        /// <value></value>
        public int TotalProduct {get; set;}

        /// <summary>
        /// Auto Prop for OrderHistory
        /// </summary>
        /// <value></value>
        public Dictionary<int,string> OrderHistory {get; set;}

        /// <summary>
        /// Location constructor
        /// </summary>
        /// <param name="totalProduct"></param>
        /// <param name="orderHistory"></param>
        public Location(int totalProduct, Dictionary<int,string> orderHistory)
        {
            TotalProduct = totalProduct;
            OrderHistory = orderHistory;
        } 
    }
}