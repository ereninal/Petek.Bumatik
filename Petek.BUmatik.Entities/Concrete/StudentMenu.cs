using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class StudentMenu:Base,IEntity
    {
        public bool  Status { get; set; }
        public string SeledtedItem { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
    public class StudentMenuConfiguration : IEntityTypeConfiguration<StudentMenu>
    {
        public void Configure(EntityTypeBuilder<StudentMenu> builder)
        {

        }
    }
}
