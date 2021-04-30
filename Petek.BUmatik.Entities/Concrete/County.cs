using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class County : Base, IEntity
    {
        public string CountryName{ get; set; }
        public virtual AdminUser AdminUser { get; set; }

        public virtual ICollection<City> Cities { get; set; }


    }
    public class CountryEntityConfiguration : IEntityTypeConfiguration<County>
    {
        public void Configure(EntityTypeBuilder<County> builder)
        {
            builder.HasMany(m => m.Cities)
               .WithOne(e => e.Counties)
               .HasForeignKey(e => e.CountryId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
