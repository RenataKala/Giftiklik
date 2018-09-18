using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiftiKlik.Models
{
    public class AdminViewModels
    {
        public IEnumerable<VenuesViewModel> VenuesViewModels { get; set; }
        public IEnumerable<VenueTypeVM> VenueTypeVMs { get; set; }
        public IEnumerable<CardViewModel> CardViewModels { get; set; }
    }

}