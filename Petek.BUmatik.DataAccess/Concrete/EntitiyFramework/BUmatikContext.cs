using Microsoft.EntityFrameworkCore;
using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Text;
using Petek.BUmatik.Shared.Constants;
using Petek.BUmatik.Core.Utilities.Security.Hashing;

namespace Petek.BUmatik.DataAccess.Concrete.EntitiyFramework
{
    public class BUmatikContext : DbContext
    {
       
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(PostgreDb.ConnectionStringLocal);
        }

        #region Model
        public DbSet<Student> Students { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<School> Schools{ get; set; }
        public DbSet<OperationClaim> OperationClaims{ get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims{ get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var createdDate = DateTime.Parse("21-04-2021 00:00:00");
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash("12345aa", out passwordHash, out passwordSalt);



            var operationClaims = new OperationClaim[]
            {
                new OperationClaim { Id = 1, Name = "Admin",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 2, Name = "Member",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 4, Name = "Student.Add",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 5, Name = "Student.GetById",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 6, Name = "Student.Delete",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 7, Name = "Student.Update",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 8, Name = "Parent.Add",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 9, Name = "Parent.Delete",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 10, Name = "Parent.Update",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
            };
            modelBuilder.Entity<OperationClaim>().HasData(operationClaims);


            var userOperationClaims = new UserOperationClaim[]
            {
                new UserOperationClaim{Id=1,ParentId=1,IsDeleted=false,CreatedDate=createdDate,CreatedUserId=1,OperationClaimId=1},
                new UserOperationClaim{Id=2,ParentId=1,IsDeleted=false,CreatedDate=createdDate,CreatedUserId=1,OperationClaimId=2},
            };
            modelBuilder.Entity<UserOperationClaim>().HasData(userOperationClaims);

            var parents = new Parent[]
            {
                new Parent{Id=1,FullName="Eren İNAL",Email="ereninal10@gmail.com",CreatedUserId=1,CreatedDate=createdDate,IsDeleted=false,PasswordHash=passwordHash,PasswordSalt=passwordSalt }
            };
            modelBuilder.Entity<Parent>().HasData(parents);

            var schools = new School[]
            {
                new School{Id=1,Name="Selçuk Üniversitesi",CityId=42,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=2,Name="Beykent Üniversitesi",CityId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=3,Name="Sabancı Üniversitesi",CityId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=4,Name="Koç Üniversitesi",CityId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=5,Name="Yıldız Teknik Üniversitesi",CityId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=6,Name="İstanbul Üniversitesi",CityId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=7,Name="İstanbul Teknik Üniversitesi",CityId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=8,Name="Karadeniz Teknik Üniversitesi",CityId=61,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=9,Name="Ege Üniversitesi",CityId=35,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=10,Name="Konya Teknik Üniversitesi",CityId=42,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=11,Name="Kocaeli Üniversitesi",CityId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=12,Name="Gebze Teknik Üniversitesi",CityId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=13,Name="Fırat Üniversitesi",CityId=67,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=14,Name="Namık Kemal Üniversitesi",CityId=59,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=15,Name="Trakya Üniversitesi",CityId=22,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=16,Name="Ankara Üniversitesi",CityId=1,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=17,Name="Orta Doğu Teknik Üniversitesi",CityId=1,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=18,Name="Bilkent Üniversitesi",CityId=1,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=19,Name="Çanakkale 18 Mart Üniversitesi",CityId=17,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=20,Name="Süleyman Demirel Üniversitesi",CityId=32,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=21,Name="İstanbul Aydın Üniversitesi",CityId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=22,Name="Nişantaşı Üniversitesi",CityId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=23,Name="Marmara Üniversitesi",CityId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=24,Name="Boğaziçi Üniversitesi",CityId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=25,Name="Gelişim Üniversitesi",CityId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=26,Name="Milli Savunma Üniversitesi",CityId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
            };

            modelBuilder.Entity<School>().HasData(schools);

            var students = new Student[]
            {
                new Student{Id=1,FullName="Mira İNAL",BandNumber="11111",CreatedDate=createdDate,IsDeleted=false,ParentId=1,CreatedUserId=1,RemainingMoney=50,SchoolId=1},
                new Student{Id=2,FullName="Aras İNAL",BandNumber="22222",CreatedDate=createdDate,IsDeleted=false,ParentId=1,CreatedUserId=1,RemainingMoney=50,SchoolId=2},
                //new Student{Id=1,FullName="Mahmut Kaçak",BandNumber="33333",CreatedDate=createdDate,IsDeleted=false,ParentId=2,CreatedUserId=1,RemainingMoney=50},
                //new Student{Id=1,FullName="Mesut Toma",BandNumber="44444",CreatedDate=createdDate,IsDeleted=false,ParentId=3,CreatedUserId=1,RemainingMoney=50},
                //new Student{Id=1,FullName="Ali Kaydırmalı",BandNumber="55555",CreatedDate=createdDate,IsDeleted=false,ParentId=4,CreatedUserId=1,RemainingMoney=50},
                //new Student{Id=1,FullName="Eda Albayrak",BandNumber="66666",CreatedDate=createdDate,IsDeleted=false,ParentId=5,CreatedUserId=1,RemainingMoney=50},
            };
            modelBuilder.Entity<Student>().HasData(students);

            base.OnModelCreating(modelBuilder);
        }


    }
}
