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
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(p => p.CustomerId);
            builder.Property(p => p.ContactName).HasMaxLength(50);
            builder.Property(p => p.CompanyName).HasMaxLength(50);
            builder.Property(p => p.City).HasMaxLength(30);

            builder.ToTable("Customers");
            builder.Property(p => p.CustomerId).HasColumnName("CustomerId");
            builder.Property(p => p.ContactName).HasColumnName("ContactName");
            builder.Property(p => p.CompanyName).HasColumnName("CompanyName");
            builder.Property(p => p.City).HasColumnName("City");
        }
    }
}
