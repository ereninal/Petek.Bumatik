using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class AdminUser : Base, IEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Parent> Parents{ get; set; }
        public virtual ICollection<City> Cities{ get; set; }
        public virtual ICollection<County> Counties{ get; set; }
        public virtual ICollection<UserOperationClaim> OperationClaims { get; set; }
        public virtual ICollection<School> Schools{ get; set; }
        public virtual ICollection<UserOperationClaim> UserOperationClaims{ get; set; }

    }
    public class AdminUserConfiguration : IEntityTypeConfiguration<AdminUser>
    {
        public void Configure(EntityTypeBuilder<AdminUser> builder)
        {
            builder.HasMany(m => m.Students)
                .WithOne(e => e.AdminUser)
                .HasForeignKey(e => e.CreatedUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.Parents)
                .WithOne(e => e.AdminUser)
                .HasForeignKey(e => e.CreatedUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.Cities)
                .WithOne(e => e.AdminUser)
                .HasForeignKey(e => e.CreatedUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.Counties)
                .WithOne(e => e.AdminUser)
                .HasForeignKey(e => e.CreatedUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.OperationClaims)
                .WithOne(e => e.AdminUser)
                .HasForeignKey(e => e.CreatedUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.Schools)
                .WithOne(e => e.AdminUser)
                .HasForeignKey(e => e.CreatedUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.UserOperationClaims)
               .WithOne(e => e.AdminUser)
               .HasForeignKey(e => e.CreatedUserId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
