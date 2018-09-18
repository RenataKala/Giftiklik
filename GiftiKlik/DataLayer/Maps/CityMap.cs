using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Maps
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            ToTable("City");
            HasKey(t => t.CityID);
            Property(t => t.CityID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(t => t.CityName).HasMaxLength(50).IsRequired();
        }
    }
}
