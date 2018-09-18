using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public int RecepientID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        //mapped
        public virtual User User { get; set; }
        //mapped
        public virtual Recepient Recepient { get; set; }
        //mapped
        public virtual OrderDetails OrderDetails { get; set; }
    }
}
