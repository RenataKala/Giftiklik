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
    public class VaucherMap : EntityTypeConfiguration<Vaucher>
    {
        public VaucherMap()
        {
            ToTable("Vaucher");
            HasKey(t => t.VaucherID);
            Property(t => t.VaucherID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.Amount).IsRequired();
            Property(t => t.HasCard).IsOptional();
        }
    }
}
