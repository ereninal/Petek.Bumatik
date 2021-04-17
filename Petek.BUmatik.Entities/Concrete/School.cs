using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class School : Base, IEntity
    {
        public string Name { get; set; }
        public int CityId { get; set; }
        public int TownId { get; set; }

        public virtual ICollection<Student> Students { get; set; }


    }
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.HasMany(m => m.Students)
                .WithOne(e => e.Schools)
                .HasForeignKey(e => e.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
