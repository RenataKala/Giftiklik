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
    public class OrderDetailsMap : EntityTypeConfiguration<OrderDetails>
    {
        public OrderDetailsMap()
        {
            ToTable("OrderDetails");
            HasKey(t => t.OrderID);
            Property(t => t.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
    }
}
