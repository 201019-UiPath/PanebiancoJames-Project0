using System;
using System.Collections.Generic;

namespace GameKingdomDB.Entities
{
    public partial class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public int? Chartype { get; set; }

        public virtual Charactertype ChartypeNavigation { get; set; }
    }
}
