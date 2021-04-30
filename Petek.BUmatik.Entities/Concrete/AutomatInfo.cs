using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class AutomatInfo
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        public int Count { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastRepairDate { get; set; }
        public int SchoolId { get; set; }

        public virtual School Schools { get; set; }
        public virtual AdminUser AdminUser { get; set; }

    }
    public class AutomatInfoConfiguration : IEntityTypeConfiguration<AutomatInfo>
    {
        public void Configure(EntityTypeBuilder<AutomatInfo> builder)
        {
            
        }
    }
}
