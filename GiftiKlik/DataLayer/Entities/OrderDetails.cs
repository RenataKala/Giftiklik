using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class OrderDetails
    {
        public int OrderID{ get; set; }
        public int VaucherID { get; set; }
        //mapped
        public virtual Order Order { get; set; }
    }
}
