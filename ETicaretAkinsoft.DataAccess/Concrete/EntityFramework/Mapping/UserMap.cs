using ETicaretAkinsoft.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAkinsoft.DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName).HasMaxLength(50);
            builder.Property(p => p.LastName).HasMaxLength(50);
            builder.Property(p => p.Email).HasMaxLength(80);


            builder.ToTable("Users");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.FirstName).HasColumnName("FirstName");
            builder.Property(p => p.LastName).HasColumnName("LastName");
            builder.Property(p => p.Email).HasColumnName("Email");
            builder.Property(p => p.PasswordSalt).HasColumnName("PasswordSalt");
            builder.Property(p => p.PasswordHash).HasColumnName("PasswordHash");
            builder.Property(p => p.Status).HasColumnName("Status");
        }
    }
}
