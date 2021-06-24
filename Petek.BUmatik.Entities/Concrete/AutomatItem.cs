using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class AutomatItem : Base, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int InfoId { get; set; }
        public virtual ItemCategory ItemCategory { get; set; }
        public virtual AutomatItemInfo AutomatItemInfo{ get; set; }
        public virtual ICollection<SelectedMenuItems> SelectedMenuItems{ get; set; }


    }
    public class AutomatItemConfiguration : IEntityTypeConfiguration<AutomatItem>
    {
        public void Configure(EntityTypeBuilder<AutomatItem> builder)
        {
            builder.HasMany(m => m.SelectedMenuItems)
                .WithOne(e => e.AutomatItem)
                .HasForeignKey(e => e.ItemId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
