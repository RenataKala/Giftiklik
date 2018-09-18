using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Card
    {
        public int CardID { get; set; }
        public string CardImagePAth { get; set; }
        //mapped
        public virtual ICollection<Vaucher> Vauchers { get; set; }
    }
}
