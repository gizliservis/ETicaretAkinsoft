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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(p => p.CategoryId);
            builder.Property(p => p.CategoryName).HasMaxLength(30);

            builder.ToTable("Categories");
            builder.Property(p => p.CategoryId).HasColumnName("CategoryId");
            builder.Property(p => p.CategoryName).HasColumnName("CategoryName");

        }
    }
}
