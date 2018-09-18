using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Maps
{
    public class VenuesMap : EntityTypeConfiguration<Venues>
    {
        public VenuesMap()
        {
            ToTable("Venues");

            HasKey(t => t.VenueID);
            Property(t => t.VenueID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.Name).HasMaxLength(50).IsRequired();
            Property(t => t.Street).HasMaxLength(50).IsOptional();
            Property(t => t.StreetNumber).IsOptional();
            Property(t => t.Street).HasMaxLength(15).IsOptional();

            HasMany(t => t.Vauchers)
                .WithRequired(t => t.Venues)
                .WillCascadeOnDelete(false);

            HasRequired(t => t.VenueType)
                .WithMany(t => t.Venues)
                .WillCascadeOnDelete(false);

            HasRequired(t => t.City)
           .WithMany(t => t.Venues)
           .WillCascadeOnDelete(false);

        }
    }
}
