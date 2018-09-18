using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DataLayer.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Maps
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            ToTable("Order");

            HasKey(t => t.OrderID);
            Property(t => t.OrderID)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.OrderDate).IsOptional();
            Property(t => t.DeliveryDate).IsOptional();

            HasOptional(t => t.OrderDetails)
                .WithRequired(t => t.Order)
                .WillCascadeOnDelete(true);
        }
    }
}
