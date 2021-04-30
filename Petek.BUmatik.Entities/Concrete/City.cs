using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class City: Base, IEntity
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public virtual  County Counties { get; set; }
        public virtual AdminUser AdminUser { get; set; }


    }
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
           
        }
    }
}
