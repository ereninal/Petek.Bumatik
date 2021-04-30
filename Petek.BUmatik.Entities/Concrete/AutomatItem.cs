using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class AutomatItem:Base,IEntity
    {
        public string Name{ get; set; }
        public int Count { get; set; }
        public DateTime LastUseDate{ get; set; }

    }
    public class AutomatItemConfiguration : IEntityTypeConfiguration<AutomatItem>
    {
        public void Configure(EntityTypeBuilder<AutomatItem> builder)
        {

        }
    }
}
