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
    public class VenueTypeRepository : IVenueType
    {
        private GiftiContext db;

        public VenueTypeRepository()
        {
            db = new GiftiContext();
        }

        public List<VenueType> GetAllTypes()
        {
            return db.VenueTypes.ToList();
        }

        public void Insert(VenueType type)
        {
            if (type == null)
                return;
            db.VenueTypes.Add(type);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            if (!db.VenueTypes.Any(t => t.VenueTypeID == id))
                return;
            db.VenueTypes.Remove(db.VenueTypes.SingleOrDefault(t => t.VenueTypeID == id));
            db.SaveChanges();
        }



    }
}
