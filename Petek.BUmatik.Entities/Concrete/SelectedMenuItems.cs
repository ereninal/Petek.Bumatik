using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class SelectedMenuItems:Base,IEntity
    {
        public int Count { get; set; }
        public int MenuId { get; set; }
        public int ItemId { get; set; }
        public int StudentId { get; set; }

        public bool LastStatus{ get; set; }
        public DateTime LastStatusDate{ get; set; }
        public virtual Menu Menu { get; set; }
        public virtual AutomatItem AutomatItem{ get; set; }
        public virtual Student Student{ get; set; }
    }
    public class SelectedMenuItemsConfiguration : IEntityTypeConfiguration<SelectedMenuItems>
    {
        public void Configure(EntityTypeBuilder<SelectedMenuItems> builder)
        {

        }
    }
}
