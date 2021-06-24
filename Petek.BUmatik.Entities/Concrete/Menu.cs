using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class Menu : Base, IEntity
    {
        public int MenuTypeId { get; set; }
        public int StudentId { get; set; }

        public virtual MenuType MenuType { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<SelectedMenuItems> SelectedMenuItems { get; set; }

    }
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasMany(m => m.SelectedMenuItems)
                .WithOne(e => e.Menu)
                .HasForeignKey(e => e.MenuId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
