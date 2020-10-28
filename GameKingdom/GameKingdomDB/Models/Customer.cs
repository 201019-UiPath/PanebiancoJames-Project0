using System.Collections.Generic;

namespace GameKingdomDB.Models
{
    /// <summary>
    /// Customer Class
    /// </summary>
    public class Customer : Person
    {
        public List<User> Address {get; set;}
    }
}