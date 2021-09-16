﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
        public int ParentId { get; set; } //N olmalı(1-N) ilişkisi için


        public virtual School Schools { get; set; }
        public virtual Parent Parents { get; set; }
        public virtual AdminUser AdminUser { get; set; }

        public virtual ICollection<StudentMenu> StudentMenus{ get; set; }
        public virtual ICollection<SelectedMenuItems> SelectedMenuItems { get; set; }
        public virtual ICollection<Menu> Menus{ get; set; }
        public virtual ICollection<Transaction> Transactions{ get; set; }

    }
    public class StudentEntityConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasMany(m => m.StudentMenus)
               .WithOne(e => e.Student)
               .HasForeignKey(e => e.StudentId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.SelectedMenuItems)
               .WithOne(e => e.Student)
               .HasForeignKey(e => e.StudentId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.Menus)
               .WithOne(e => e.Student)
               .HasForeignKey(e => e.StudentId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.Transactions)
               .WithOne(e => e.Student)
               .HasForeignKey(e => e.StudentId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
