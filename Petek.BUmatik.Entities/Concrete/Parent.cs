using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class Parent : Base, IEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public virtual AdminUser AdminUser { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<UserOperationClaim> OperationClaims { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }


    }
    public class ParentConfiguration : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
        {
            builder.HasMany(m => m.Students)
                .WithOne(e => e.Parents)
                .HasForeignKey(e => e.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.OperationClaims)
                .WithOne(e => e.Parents)
                .HasForeignKey(e => e.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.Transactions)
               .WithOne(e => e.Parent)
               .HasForeignKey(e => e.ParentId)
               .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
