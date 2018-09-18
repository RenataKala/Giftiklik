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
    public class UserMap :EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("User");

            HasKey(t => t.UserID);
            Property(t => t.UserID)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.FirstName).HasMaxLength(50).IsOptional();
            Property(t => t.LastName).HasMaxLength(50).IsOptional();
            Property(t => t.Email).HasMaxLength(50).IsRequired();
            Property(t => t.Password).HasMaxLength(50).IsRequired();
            Property(t => t.Username).HasMaxLength(50).IsOptional();


            HasMany(t => t.Order)
                .WithRequired(t => t.User)
                .WillCascadeOnDelete(false);
        }
    }
}
