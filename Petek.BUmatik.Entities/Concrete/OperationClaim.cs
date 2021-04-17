using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class OperationClaim:Base, IEntity
    {
        public string Name{ get; set; }
        public virtual ICollection<UserOperationClaim> OperationClaims { get; set; }

    }
    public class OperationClaimEntityConfiguration : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.HasMany(m => m.OperationClaims)
                 .WithOne(e => e.OperationClaims)
                 .HasForeignKey(e => e.OperationClaimId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
