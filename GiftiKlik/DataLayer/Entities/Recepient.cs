using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Recepient
    {
        public int  RecepientID { get; set; }
        public string Email { get; set; }
        //mapped
        public virtual ICollection<Order> Order { get; set; }
    }
}
