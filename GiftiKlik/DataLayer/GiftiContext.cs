using DataLayer.Entities;
using DataLayer.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class GiftiContext : DbContext
    {
        public GiftiContext()
       : base(AppConfiguration.ConnectionString)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Venues> Venues { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Recepient> Recepients { get; set; }
        public DbSet<Vaucher> Vauchers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<VenueType> VenueTypes { get; set; }
        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new OrderDetailsMap());
            modelBuilder.Configurations.Add(new RecepientMap());
            modelBuilder.Configurations.Add(new VenuesMap());
            modelBuilder.Configurations.Add(new VaucherMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new VenuesTypeMap());
            modelBuilder.Configurations.Add(new CardMap());
        }
    }
}
