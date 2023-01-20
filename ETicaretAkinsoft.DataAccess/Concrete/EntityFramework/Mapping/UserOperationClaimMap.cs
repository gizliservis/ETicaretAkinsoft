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
    public class UserOperationClaimMap : IEntityTypeConfiguration<UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            builder.HasKey(p => p.Id);
           

            builder.ToTable("UserOperationClaimMap");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.UserId).HasColumnName("UserId");
            builder.Property(p => p.OperationClaimId).HasColumnName("OperationClaimId");
        }
    }
}
