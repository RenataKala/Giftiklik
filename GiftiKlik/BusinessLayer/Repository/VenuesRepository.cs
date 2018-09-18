using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository
{
    public class VenuesRepository : IVenues
    {
        private GiftiContext db;

        public VenuesRepository()
        {
            db = new GiftiContext();
        }

        public IQueryable<Venues> GetAllVenues()
        {
            return db.Venues;
        }

        public List<Venues> SearchVenueByLocation(string location)
        {
            var venues = GetAllVenues()
                            .Where(t => t.City.CityName == location)
                            .ToList();
            return venues;
        }

        public List<Venues> SearchVenueByType(string venueType)
        {
            var venues = db.Venues
                                .Where(t => t.VenueType.Type == venueType)
                                .ToList();
            return venues;
        }

        public List<Venues> SearchVenuesByTypeID(int id)
        {
            string type = db.VenueTypes.Any(t => t.VenueTypeID == id).ToString();
            var venues = db.Venues.Where(t => t.VenueType.Type == type).ToList();
            return venues;
        }

        public Venues GetVenueById(int id)
        {
            return db.Venues.SingleOrDefault(t => t.VenueID == id);
        }


        public void Insert(Venues venue)
        {
            if (venue == null)
                return;
            db.Venues.Add(venue);
            db.SaveChanges();
        }

        public void Delete(Venues venue)
        {
            if (venue == null) return;
            db.Venues.Remove(venue);
            db.SaveChanges();
        }

        public void Delete(int VenuesID)
        {
            Delete(GetVenueById(VenuesID));
        }

        public void Update(Venues venue)
        {
            if (venue != null && Exists(venue.VenueID))
            {
                db.SaveChanges();
            }
        }
        public bool Exists(int VenuesID)
        {
            return db.Venues.Any(t => t.VenueID == VenuesID);
        }




       

        public List<Venues> SearchVenueByName(string name)
        {
            throw new NotImplementedException();
        }      

       
    }
}
