using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class MenuType : Base, IEntity
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public TimeSpan StartDate { get; set; }
        public TimeSpan FinishDate { get; set; }
        public virtual ICollection<Menu> Menus{ get; set; }
        public virtual ICollection<Transaction> Transactions{ get; set; }

    }
    public class MenuTypeConfiguration : IEntityTypeConfiguration<MenuType>
    {
        public void Configure(EntityTypeBuilder<MenuType> builder)
        {
            builder.HasMany(m => m.Menus)
               .WithOne(e => e.MenuType)
               .HasForeignKey(e => e.MenuTypeId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.Transactions)
               .WithOne(e => e.MenuType)
               .HasForeignKey(e => e.MenuTypeId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
