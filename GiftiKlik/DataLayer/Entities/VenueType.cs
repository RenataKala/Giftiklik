using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class VenueType
    {
        public int VenueTypeID { get; set; }
        public string Type { get; set; }
        //mapped
        public virtual ICollection<Venues> Venues { get; set; }
    }
}
