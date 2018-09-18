using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        //mapped
        public virtual ICollection<Venues> Venues { get; set; }
    }
}
