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
    public class RecepientMap : EntityTypeConfiguration<Recepient>
    {
        public RecepientMap()
        {
            ToTable("Recepient");

            HasKey(t => t.RecepientID);
            Property(t => t.RecepientID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            Property(t => t.Email).HasMaxLength(50).IsRequired();

            HasMany(t => t.Order)
                .WithRequired(t => t.Recepient)
                .WillCascadeOnDelete(false);

        }
    }
}
