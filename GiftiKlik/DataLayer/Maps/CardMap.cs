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
    public class CardMap : EntityTypeConfiguration<Card>
    {
        public CardMap()
        {
            ToTable("Card");
            HasKey(t => t.CardID);
            Property(t => t.CardID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.CardImagePAth).HasMaxLength(128).IsOptional();
            HasMany(t => t.Vauchers)
               .WithRequired(t => t.Card)
               .WillCascadeOnDelete(false);
        }
    }
}
