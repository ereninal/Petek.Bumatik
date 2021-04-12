using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petek.BUmatik.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class Parent : Base, IEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

        public virtual ICollection<Student> Students { get; set; }


    }
    public class ParentConfiguration : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
        {
            builder.HasMany(m => m.Students)
                .WithOne(e => e.Parents)
                .HasForeignKey(e => e.ParentId)
                .OnDelete(DeleteBehavior.Restrict);
                
        }
    }
}
