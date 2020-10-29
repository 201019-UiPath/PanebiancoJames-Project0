using System;
using System.Collections.Generic;

namespace GameKingdomDB.Entities
{
    public partial class Charactertype
    {
        public Charactertype()
        {
            People = new HashSet<People>();
        }

        public int Id { get; set; }
        public string Chartype { get; set; }

        public virtual ICollection<People> People { get; set; }
    }
}
