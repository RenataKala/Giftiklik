using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiftiKlik.Models
{
    public class VenuesViewModel
    {
        public VenuesViewModel()
        {

        }
        public VenuesViewModel(Venues venues)
        {
            VenueID = venues.VenueID;
            VenueTypeID = venues.VenueTypeID;
            CityID = venues.CityID;
            Name = venues.Name;
            Street = venues.Street;
            StreetNumber = venues.StreetNumber;
            Phone = venues.Phone;
            CityName = venues.City.CityName;
            VenueType = venues.VenueType.Type;

        }

        public int VenueID { get; set; }
        public int VenueTypeID { get; set; }
        public int CityID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string Phone { get; set; }
        public string CityName { get; set; }

        public string VenueType { get; set; }
  
    }
}