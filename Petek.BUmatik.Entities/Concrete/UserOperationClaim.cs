using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class UserOperationClaim:Base, IEntity
    {
        public int ParentId { get; set; }
        public int OperationClaimId { get; set; }
        public virtual OperationClaim OperationClaims { get; set; }
        public virtual Parent Parents{ get; set; }
        public virtual AdminUser AdminUser { get; set; }

    }
    public class UserOperationClaimEntityConfiguration : IEntityTypeConfiguration<UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            //builder.HasOne(m => m.School)
            //    .WithMany(b => b.Students)
            //    .HasForeignKey(s=>s.SchoolId)
            //    .OnDelete(DeleteBehavior.Restrict)
            //    .IsRequired();
        }
    }
}
