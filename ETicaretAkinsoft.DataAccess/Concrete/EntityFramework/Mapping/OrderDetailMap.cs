using ETicaretAkinsoft.Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAkinsoft.DataAccess.Concrete.EntityFramework.Mapping
{
    public class OrderDetailMap : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(p => p.OrderDetailId);
            builder.Property(p => p.UnitPrice).HasPrecision(12,2);
            builder.Property(p => p.TotalPrice).HasPrecision(12,2);
            builder.Property(p => p.Amount).HasPrecision(12,2);
            builder.Property(p => p.Unit).HasMaxLength(30);

            builder.ToTable("OrderDetails");
            builder.Property(p => p.OrderDetailId).HasColumnName("OrderDetailId");
            builder.Property(p => p.OrderId).HasColumnName("OrderId");
            builder.Property(p => p.ProductId).HasColumnName("ProductId");
            builder.Property(p => p.UnitPrice).HasColumnName("UnitPrice");
            builder.Property(p => p.TotalPrice).HasColumnName("TotalPrice");
            builder.Property(p => p.Amount).HasColumnName("Amount"); 
            builder.Property(p => p.Unit).HasColumnName("Unit"); 
        }
    }
}
