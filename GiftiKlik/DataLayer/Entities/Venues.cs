using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Venues
    {
        public int VenueID { get; set; }
        public int VenueTypeID { get; set; }
        public int CityID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string Phone { get; set; }
        //mapped
        public virtual City City { get; set; }
        //mapped
        public virtual VenueType VenueType { get; set; }
        //mapped
        public virtual ICollection<Vaucher> Vauchers { get; set; }
        
    }
}
