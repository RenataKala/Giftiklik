using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Maps
{
    public class VenuesTypeMap : EntityTypeConfiguration<VenueType>
    {
        public VenuesTypeMap()
        {
            ToTable("VenueType");
            HasKey(t => t.VenueTypeID);
            Property(t => t.VenueTypeID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(t => t.Type).HasMaxLength(50).IsRequired();
        }

    }
}
