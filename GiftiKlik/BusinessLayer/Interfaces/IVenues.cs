using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IVenues
    {

        IQueryable<Venues> GetAllVenues();
        Venues GetVenueById(int id);
        void Insert(Venues venue);
        void Update(Venues venue);
        void Delete(Venues venue);
        void Delete(int VenuesID);
        bool Exists(int VenuesID);
        List<Venues> SearchVenueByLocation(string location);
        List<Venues> SearchVenueByName(string name);
        List<Venues> SearchVenueByType(string venueType);
        List<Venues> SearchVenuesByTypeID(int id);

    }
}
