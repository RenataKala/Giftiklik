
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Vaucher
    {
        public int VaucherID { get; set; }
        public int VenueID { get; set; }
        public int CardID { get; set; }
        public int Amount { get; set; }
        public bool HasCard { get; set; }
        //mapped
        public virtual Venues Venues { get; set; }
        //mapped
        public virtual Card Card { get; set; }


    }
}
