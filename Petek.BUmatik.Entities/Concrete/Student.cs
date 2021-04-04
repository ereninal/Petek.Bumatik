using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petek.BUmatik.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class Student : Base, IEntity
    {
      
        public string  FullName { get; set; }
        public byte[]? Image{ get; set; }
        public decimal RemainingMoney { get; set; }
        public string BandNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? ModifieUserId { get; set; }//N olmalı(1-N) ilişkisi için
        public int SchoolId { get; set; }//N olmalı(1-N) ilişkisi için

        public int? ParentId { get; set; } //N olmalı(1-N) ilişkisi için
        //public virtual School School { get; set; }
        //public virtual Parent Parent{ get; set; }
        

    }
    public class StudentEntityConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //builder.HasOne(m => m.School)
            //    .WithMany(b => b.Students)
            //    .HasForeignKey(s=>s.SchoolId)
            //    .OnDelete(DeleteBehavior.Restrict)
            //    .IsRequired();
        }
    }

}
