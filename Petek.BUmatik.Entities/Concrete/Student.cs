using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petek.BUmatik.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class Student: IEntity
    {
        public int Id { get; set; }
        public string  FullName { get; set; }
        public byte[]? Image{ get; set; }
        public decimal RemainMoney { get; set; }
        public string BandNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? CreatedUserId { get; set; }//N olmalı(1-N) ilişkisi için
        public int? ModifieUserId { get; set; }//N olmalı(1-N) ilişkisi için
        public bool IsDeleted { get; set; }
        public int SchoolId { get; set; }//N olmalı(1-N) ilişkisi için

        public virtual School School { get; set; }
        public int ParentId { get; set; } //N olmalı(1-N) ilişkisi için
        

    }
    //public class StudentEntityConfiguration : IEntityTypeConfiguration<Student>
    //{
    //    public void Configure(EntityTypeBuilder<Student> builder)
    //    {
    //        builder.
    //    }
    //}

}
