using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class ItemCategory : Base, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AutomatItem> AutomatItems{ get; set; }

    }
    public class ItemCategoryConfiguration : IEntityTypeConfiguration<ItemCategory>
    {
        public void Configure(EntityTypeBuilder<ItemCategory> builder)
        {
            builder.HasMany(m => m.AutomatItems)
               .WithOne(e => e.ItemCategory)
               .HasForeignKey(e => e.ItemCategoryId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
