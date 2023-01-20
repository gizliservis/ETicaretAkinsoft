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
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.UnitPrice).HasPrecision(12, 2);
            builder.Property(p => p.ProductName).HasMaxLength(30);

            builder.ToTable("Products");
            builder.Property(p => p.ProductId).HasColumnName("ProductId");
            builder.Property(p => p.CategoryId).HasColumnName("CategoryId");
            builder.Property(p => p.UnitPrice).HasColumnName("UnitPrice");
            builder.Property(p => p.ProductName).HasColumnName("ProductName");
            builder.Property(p => p.UnitsInStock).HasColumnName("UnitsInStock");
        }
    }
}
