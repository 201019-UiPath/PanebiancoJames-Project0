using System.Collections.Generic;

namespace GameKingdomDB.Models
{
    /// <summary>
    /// Location Class
    /// </summary>
    public class Location
    {
        public int Id {get; set;}
        
        public string State {get; set;}
        public string City {get; set;}
        public string Street {get; set;}
        
    }
}