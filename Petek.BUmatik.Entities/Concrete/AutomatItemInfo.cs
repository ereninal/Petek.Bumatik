using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class AutomatItemInfo : Base, IEntity
    {
        public int Count { get; set; }

        public virtual ICollection<AutomatItem> AutomatItems { get; set; }


    }
    public class AutomatItemInfoConfiguration : IEntityTypeConfiguration<AutomatItemInfo>
    {
        public void Configure(EntityTypeBuilder<AutomatItemInfo> builder)
        {
            builder.HasMany(m => m.AutomatItems)
              .WithOne(e => e.AutomatItemInfo)
              .HasForeignKey(e => e.AutomatItemInfoId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
