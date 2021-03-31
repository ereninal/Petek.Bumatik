using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petek.BUmatik.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class School : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public int TownId { get; set; }

        public virtual ICollection<Student> Students { get; set; }


    }
    public class CountryConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.HasMany(e => e.Students)
                .WithOne(e => e.School)
                .HasForeignKey(e => e.SchoolId);
        }
    }
}
