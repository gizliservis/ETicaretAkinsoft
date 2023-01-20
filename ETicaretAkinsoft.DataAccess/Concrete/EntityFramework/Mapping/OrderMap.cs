using ETicaretAkinsoft.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAkinsoft.DataAccess.Concrete.EntityFramework.Mapping
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(p => p.OrderId);
            builder.Property(p => p.ShipCity).HasMaxLength(30);

            builder.ToTable("Orders");
            builder.Property(p => p.OrderId).HasColumnName("OrderId");
            builder.Property(p => p.CustomerId).HasColumnName("CustomerId");
            builder.Property(p => p.EmployeeId).HasColumnName("EmployeeId");
            builder.Property(p => p.OrderDate).HasColumnName("OrderDate");
            builder.Property(p => p.ShipCity).HasColumnName("ShipCity");
        }
    }
}
