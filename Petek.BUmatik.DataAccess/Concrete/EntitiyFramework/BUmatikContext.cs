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
            optionsBuilder.UseNpgsql(PostgreDb.ConnectionStringTest);
        }

        #region Model
        public DbSet<Student> Students { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<SendEmailOrSms> SendEmailOrSms{ get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<AutomatItemInfo> AutomatItemInfos{ get; set; }
        public DbSet<ItemCategory> ItemCategories{ get; set; }
        public DbSet<AutomatItem> AutomatItems{ get; set; }
        public DbSet<SelectedMenuItems> SelectedMenuItems{ get; set; }
        public DbSet<MenuType> MenuTypes{ get; set; }
        public DbSet<Menu> Menus{ get; set; }
        public DbSet<StudentMenu> StudentMenus{ get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var createdDate = DateTime.Parse("21-04-2021 00:00:00");
            var createdDate = DateTime.Now;
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash("12345aa", out passwordHash, out passwordSalt);

            #region AdminUser
            var adminUsers = new AdminUser[] {
                new AdminUser{Id=1,FullName="Eren İnal",Email="eren@petek.com",CreatedDate=createdDate,IsDeleted=false,PasswordHash=passwordHash,PasswordSalt=passwordSalt},
                new AdminUser{Id=2,FullName="Peinsu Baltacı",Email="pelinsu@petek.com",CreatedDate=createdDate,IsDeleted=false,PasswordHash=passwordHash,PasswordSalt=passwordSalt},
                new AdminUser{Id=3,FullName="Mehmet Kemal Sarıkaya",Email="kemal@petek.com",CreatedDate=createdDate,IsDeleted=false,PasswordHash=passwordHash,PasswordSalt=passwordSalt},
                new AdminUser{Id=4,FullName="Samet Dikmen",Email="samet@petek.com",CreatedDate=createdDate,IsDeleted=false,PasswordHash=passwordHash,PasswordSalt=passwordSalt},
            };
            modelBuilder.Entity<AdminUser>().HasData(adminUsers);
            #endregion

            #region OperationClaim
            var operationClaims = new OperationClaim[]
            {
                new OperationClaim { Id = 1, Name = "Admin",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 2, Name = "Member",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 3, Name = "Member.Create",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 4, Name = "Student.Add",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 5, Name = "Student.GetById",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 6, Name = "Student.Delete",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 7, Name = "Student.Update",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 8, Name = "Parent.Add",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 9, Name = "Parent.Delete",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
                new OperationClaim { Id = 10, Name = "Parent.Update",CreatedUserId=1, IsDeleted = false, CreatedDate = createdDate },
            };
            modelBuilder.Entity<OperationClaim>().HasData(operationClaims);
            #endregion

            #region UserOperationClaims
            var userOperationClaims = new UserOperationClaim[]
            {
                new UserOperationClaim{Id=1,ParentId=1,IsDeleted=false,CreatedDate=createdDate,CreatedUserId=1,OperationClaimId=1},
                new UserOperationClaim{Id=2,ParentId=1,IsDeleted=false,CreatedDate=createdDate,CreatedUserId=1,OperationClaimId=2},
            };
            modelBuilder.Entity<UserOperationClaim>().HasData(userOperationClaims);
            #endregion

            #region Parents
            var parents = new Parent[]
            {
                new Parent{Id=1,FullName="Eren İNAL",Email="ereninal10@gmail.com",CreatedUserId=1,CreatedDate=createdDate,IsDeleted=false,PasswordHash=passwordHash,PasswordSalt=passwordSalt }
            };
            modelBuilder.Entity<Parent>().HasData(parents);
            #endregion

            #region Schools
            var schools = new School[]
            {
                new School{Id=1,Name="Selçuk Üniversitesi",CountryId=42,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=2,Name="Beykent Üniversitesi",CountryId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=3,Name="Sabancı Üniversitesi",CountryId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=4,Name="Koç Üniversitesi",CountryId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=5,Name="Yıldız Teknik Üniversitesi",CountryId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=6,Name="İstanbul Üniversitesi",CountryId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=7,Name="İstanbul Teknik Üniversitesi",CountryId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=8,Name="Karadeniz Teknik Üniversitesi",CountryId=61,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=9,Name="Ege Üniversitesi",CountryId=35,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=10,Name="Konya Teknik Üniversitesi",CountryId=42,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=11,Name="Kocaeli Üniversitesi",CountryId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=12,Name="Gebze Teknik Üniversitesi",CountryId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=13,Name="Fırat Üniversitesi",CountryId=67,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=14,Name="Namık Kemal Üniversitesi",CountryId=59,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=15,Name="Trakya Üniversitesi",CountryId=22,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=16,Name="Ankara Üniversitesi",CountryId=1,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=17,Name="Orta Doğu Teknik Üniversitesi",CountryId=1,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=18,Name="Bilkent Üniversitesi",CountryId=1,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=19,Name="Çanakkale 18 Mart Üniversitesi",CountryId=17,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=20,Name="Süleyman Demirel Üniversitesi",CountryId=32,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=21,Name="İstanbul Aydın Üniversitesi",CountryId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=22,Name="Nişantaşı Üniversitesi",CountryId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=23,Name="Marmara Üniversitesi",CountryId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=24,Name="Boğaziçi Üniversitesi",CountryId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=25,Name="Gelişim Üniversitesi",CountryId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new School{Id=26,Name="Milli Savunma Üniversitesi",CountryId=34,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
            };
            modelBuilder.Entity<School>().HasData(schools);
            #endregion

            #region Students
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
            #endregion

            #region Counties
            var countries = new County[] {

                new County{Id=1,CountryName="Adana",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=2,CountryName="Adıyaman",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=3,CountryName="Afyon",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=4,CountryName="Ağrı",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=5,CountryName="Amasya",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=6,CountryName="Ankara",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=7,CountryName="Antalya",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=8,CountryName="Artvin",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=9,CountryName="Aydın",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=10,CountryName="Balıkesir",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=11,CountryName="Bilecik",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=12,CountryName="Bingöl",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=13,CountryName="Bitlis",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=14,CountryName="Bolu",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=15,CountryName="Burdur",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=16,CountryName="Bursa",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=17,CountryName="Çanakkale",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=18,CountryName="Çankırı",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=19,CountryName="Çorum",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=20,CountryName="Denizli",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=21,CountryName="Diyarbakır",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=22,CountryName="Edirne",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=23,CountryName="Elazığ",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=24,CountryName="Erzincan",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=25,CountryName="Erzurum",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=26,CountryName="Eskişehir",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=27,CountryName="Gaziantep",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=28,CountryName="Giresun",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=29,CountryName="Gümüşhane",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=30,CountryName="Hakkari",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=31,CountryName="Hatay",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=32,CountryName="Isparta",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=33,CountryName="İçel",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=34,CountryName="İstanbul",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=35,CountryName="İzmir",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=36,CountryName="Kars",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=37,CountryName="Kastamonu",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=38,CountryName="Kayseri",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=39,CountryName="Kırklareli",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=40,CountryName="Kırşehir",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=41,CountryName="Kocaeli",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=42,CountryName="Konya",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=43,CountryName="Kütahya",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=44,CountryName="Malatya",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=45,CountryName="Manisa",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=46,CountryName="Kahramanmaraş",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=47,CountryName="Mardin",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=48,CountryName="Muğla",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=49,CountryName="Muş",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=50,CountryName="Nevşehir",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=51,CountryName="Niğde",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=52,CountryName="Ordu",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=53,CountryName="Rize",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=54,CountryName="Sakarya",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=55,CountryName="Samsun",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=56,CountryName="Siirt",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=57,CountryName="Sinop",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=58,CountryName="Sivas",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=59,CountryName="Tekirdağ",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=60,CountryName="Tokat",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=61,CountryName="Trabzon",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=62,CountryName="Tunceli",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=63,CountryName="Şanlıurfa",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=64,CountryName="Uşak",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=65,CountryName="Van",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=66,CountryName="Yozgat",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=67,CountryName="Zonguldak",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=68,CountryName="Aksaray",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=69,CountryName="Bayburt",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=70,CountryName="Karaman",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=71,CountryName="Kırıkkale",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=72,CountryName="Batman",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=73,CountryName="Şırnak",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=74,CountryName="Bartın",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=75,CountryName="Ardahan",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=76,CountryName="Iğdır",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=77,CountryName="Yalova",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=78,CountryName="Karabük",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=79,CountryName="Kilis",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=80,CountryName="Osmaniye",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
                new County{Id=81,CountryName="Düzce",CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false },
            };
            modelBuilder.Entity<County>().HasData(countries);
            #endregion

            #region Cities
            var cities = new City[] {
                new City{Id=1,Name="Sarıyer",CountryId=34,CreatedUserId=1,IsDeleted=false},
                new City{Id=2,Name="Beyoğlu",CountryId=34,CreatedUserId=1,IsDeleted=false},
                new City{Id=3,Name="Kartal",CountryId=34,CreatedUserId=1,IsDeleted=false},
                new City{Id=4,Name="Kadıköy",CountryId=34,CreatedUserId=1,IsDeleted=false},
                new City{Id=5,Name="Esenler",CountryId=34,CreatedUserId=1,IsDeleted=false},
                new City{Id=6,Name="Maltepe",CountryId=34,CreatedUserId=1,IsDeleted=false},
                new City{Id=7,Name="Zeytinburnu",CountryId=34,CreatedUserId=1,IsDeleted=false},
                new City{Id=8,Name="Bakırköy",CountryId=34,CreatedUserId=1,IsDeleted=false},
                new City{Id=9,Name="Beylikdüzü",CountryId=34,CreatedUserId=1,IsDeleted=false},
                new City{Id=11,Name="Selçuklu",CountryId=42,CreatedUserId=1,IsDeleted=false},
                new City{Id=12,Name="Beyşehir",CountryId=42,CreatedUserId=1,IsDeleted=false},
                new City{Id=13,Name="Akşehir",CountryId=42,CreatedUserId=1,IsDeleted=false},
                new City{Id=14,Name="Cihanbeyli",CountryId=42,CreatedUserId=1,IsDeleted=false},
                new City{Id=15,Name="Foça",CountryId=35,CreatedUserId=1,IsDeleted=false},
                new City{Id=16,Name="Selçuk",CountryId=35,CreatedUserId=1,IsDeleted=false},
                new City{Id=17,Name="Urla ",CountryId=35,CreatedUserId=1,IsDeleted=false},
                new City{Id=18,Name="Gölbaşı",CountryId=1,CreatedUserId=1,IsDeleted=false},
                new City{Id=19,Name="Şereflikoçhisar",CountryId=1,CreatedUserId=1,IsDeleted=false},
                new City{Id=20,Name="Keçiören",CountryId=1,CreatedUserId=1,IsDeleted=false},
                new City{Id=21,Name="Beypazarı",CountryId=1,CreatedUserId=1,IsDeleted=false},
                new City{Id=22,Name="Polatlı",CountryId=1,CreatedUserId=1,IsDeleted=false},
                new City{Id=23,Name="Çanakkale ",CountryId=1,CreatedUserId=1,IsDeleted=false},
                new City{Id=24,Name="Bozcaada",CountryId=17,CreatedUserId=1,IsDeleted=false},
                new City{Id=25,Name="Biga",CountryId=17,CreatedUserId=1,IsDeleted=false},
                new City{Id=26,Name="Ayvacık",CountryId=17,CreatedUserId=1,IsDeleted=false},
                new City{Id=27,Name="Ezine",CountryId=17,CreatedUserId=1,IsDeleted=false},
                new City{Id=28,Name="Gelibolu",CountryId=17,CreatedUserId=1,IsDeleted=false},
                new City{Id=29,Name="Şarköy",CountryId=59,CreatedUserId=1,IsDeleted=false},
                new City{Id=31,Name="Süleymanpaşa",CountryId=59,CreatedUserId=1,IsDeleted=false},
                new City{Id=32,Name="Çorlu",CountryId=59,CreatedUserId=1,IsDeleted=false},
                new City{Id=33,Name="Çerkezköy",CountryId=59,CreatedUserId=1,IsDeleted=false},
                new City{Id=34,Name="Saray",CountryId=59,CreatedUserId=1,IsDeleted=false},
                new City{Id=35,Name="Kapaklı",CountryId=59,CreatedUserId=1,IsDeleted=false},
                new City{Id=36,Name="Malkara",CountryId=59,CreatedUserId=1,IsDeleted=false},
                new City{Id=37,Name="Keşan",CountryId=22,CreatedUserId=1,IsDeleted=false},
                new City{Id=38,Name="Edirne",CountryId=22,CreatedUserId=1,IsDeleted=false},
                new City{Id=39,Name="İpsala",CountryId=22,CreatedUserId=1,IsDeleted=false},
                new City{Id=40,Name="Zonguldak",CountryId=67,CreatedUserId=1,IsDeleted=false},
                new City{Id=41,Name="Alaplı",CountryId=67,CreatedUserId=1,IsDeleted=false},
                new City{Id=42,Name="Gökçebey",CountryId=67,CreatedUserId=1,IsDeleted=false},
                new City{Id=43,Name="Çaycuma",CountryId=67,CreatedUserId=1,IsDeleted=false},
                new City{Id=44,Name="Akçaabat",CountryId=61,CreatedUserId=1,IsDeleted=false},
                new City{Id=45,Name="Düzköy",CountryId=61,CreatedUserId=1,IsDeleted=false},
                new City{Id=46,Name="Enez",CountryId=61,CreatedUserId=1,IsDeleted=false},
                new City{Id=47,Name="Arsin",CountryId=61,CreatedUserId=1,IsDeleted=false},
                new City{Id=48,Name="Beşikdüzü",CountryId=61,CreatedUserId=1,IsDeleted=false},

            };
            modelBuilder.Entity<City>().HasData(cities);

            #endregion

            #region AutomatInfos
            var outomatInfos = new AutomatInfo[] 
            {
                new AutomatInfo{Id=1,Number="BUMATIK-1",Brand="Pe-Tek",SchoolId=1,Count=10,CreatedDate=createdDate,LastRepairDate=createdDate,CreatedUserId=1,IsDeleted=false,StartDate=createdDate},
                new AutomatInfo{Id=2,Number="BUMATIK-2",Brand="Pe-Tek",SchoolId=2,Count=10,CreatedDate=createdDate,LastRepairDate=createdDate,CreatedUserId=1,IsDeleted=false,StartDate=createdDate},
                new AutomatInfo{Id=3,Number="BUMATIK-3",Brand="Pe-Tek",SchoolId=4,Count=10,CreatedDate=createdDate,LastRepairDate=createdDate,CreatedUserId=1,IsDeleted=false,StartDate=createdDate},
                new AutomatInfo{Id=4,Number="BUMATIK-4",Brand="Pe-Tek",SchoolId=5,Count=10,CreatedDate=createdDate,LastRepairDate=createdDate,CreatedUserId=1,IsDeleted=false,StartDate=createdDate},
                new AutomatInfo{Id=5,Number="BUMATIK-5",Brand="Pe-Tek",SchoolId=6,Count=10,CreatedDate=createdDate,LastRepairDate=createdDate,CreatedUserId=1,IsDeleted=false,StartDate=createdDate},
                new AutomatInfo{Id=6,Number="BUMATIK-6",Brand="Pe-Tek",SchoolId=7,Count=10,CreatedDate=createdDate,LastRepairDate=createdDate,CreatedUserId=1,IsDeleted=false,StartDate=createdDate},
                new AutomatInfo{Id=7,Number="BUMATIK-7",Brand="Pe-Tek",SchoolId=8,Count=10,CreatedDate=createdDate,LastRepairDate=createdDate,CreatedUserId=1,IsDeleted=false,StartDate=createdDate},
                new AutomatInfo{Id=8,Number="BUMATIK-8",Brand="Pe-Tek",SchoolId=9,Count=10,CreatedDate=createdDate,LastRepairDate=createdDate,CreatedUserId=1,IsDeleted=false,StartDate=createdDate},
                new AutomatInfo{Id=9,Number="BUMATIK-9",Brand="Pe-Tek",SchoolId=10,Count=10,CreatedDate=createdDate,LastRepairDate=createdDate,CreatedUserId=1,IsDeleted=false,StartDate=createdDate},
                new AutomatInfo{Id=10,Number="BUMATIK-10",Brand="Pe-Tek",SchoolId=11,Count=10,CreatedDate=createdDate,LastRepairDate=createdDate,CreatedUserId=1,IsDeleted=false,StartDate=createdDate},
            };
            modelBuilder.Entity<AutomatInfo>().HasData(outomatInfos);

            #endregion

            #region AutomatItemInfos
            var outomatItems = new AutomatItemInfo[]
            {
                new AutomatItemInfo{Id=1,Count=10,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false,},
                new AutomatItemInfo{Id=2,Count=10,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false,},
                new AutomatItemInfo{Id=3,Count=10,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false,},
                new AutomatItemInfo{Id=4,Count=10,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false,},
                new AutomatItemInfo{Id=5,Count=10,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false,},
                new AutomatItemInfo{Id=6,Count=10,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false,},
                new AutomatItemInfo{Id=7,Count=10,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false,},
                
                
            };
            modelBuilder.Entity<AutomatItemInfo>().HasData(outomatItems);

            #endregion

            #region StudentMenu

            var studentMenu = new StudentMenu[]
            {
                new StudentMenu{Id=1,CreatedDate=createdDate,IsDeleted=false,Status=false,SeledtedItem="{'Elma','Portakal','Su' }",StudentId=1 }
            };
            modelBuilder.Entity<StudentMenu>().HasData(studentMenu);

            #endregion

            #region ItemCategory

            var itemCategory = new ItemCategory[]
            {
                new ItemCategory{Id=1,Name="İçecek",Description="",CreatedDate=createdDate,IsDeleted=false,CreatedUserId=1},
                new ItemCategory{Id=2,Name="Katı Gıda",Description="",CreatedDate=createdDate,IsDeleted=false,CreatedUserId=1},
                new ItemCategory{Id=3,Name="Meyve",Description="",CreatedDate=createdDate,IsDeleted=false,CreatedUserId=1},
                new ItemCategory{Id=4,Name="Kuruyemiş",Description="",CreatedDate=createdDate,IsDeleted=false,CreatedUserId=1},
            };
            modelBuilder.Entity<ItemCategory>().HasData(itemCategory);

            #endregion

            #region MenuType

            var menuType = new MenuType[]
            {
                new MenuType{Id=1,Type="Sabah",StartDate= new TimeSpan(6,0,0),FinishDate=new TimeSpan(10,0,0),CreatedDate=createdDate,CreatedUserId =1,IsDeleted=false},
                new MenuType{Id=2,Type="Öğle",StartDate= new TimeSpan(12,0,0),FinishDate=new TimeSpan(3,0,0),CreatedDate=createdDate,CreatedUserId =1,IsDeleted=false},
            };
            modelBuilder.Entity<MenuType>().HasData(menuType);

            #endregion

            #region AutomatItems

            var automatItems = new AutomatItem[]
            {
                new AutomatItem{Id=1,Name="Portakal",ImagePath="../../../assets/img/automatItems/items-1.jpg",Price=2,CreatedDate=createdDate,IsDeleted=false,CreatedUserId=1,ItemCategoryId=3,AutomatItemInfoId=1},
                new AutomatItem{Id=2,Name="Ceviz",ImagePath="../../../assets/img/automatItems/items-1.jpg",Price=5,CreatedDate=createdDate,IsDeleted=false,CreatedUserId=1,ItemCategoryId=4,AutomatItemInfoId=2},
                new AutomatItem{Id=3,Name="Fındık",ImagePath="../../../assets/img/automatItems/items-1.jpg",Price=7,CreatedDate=createdDate,IsDeleted=false,CreatedUserId=1,ItemCategoryId=4,AutomatItemInfoId=3},
                new AutomatItem{Id=4,Name="Erikli Su",ImagePath="../../../assets/img/automatItems/items-1.jpg",Price=2,CreatedDate=createdDate,IsDeleted=false,CreatedUserId=1,ItemCategoryId=1,AutomatItemInfoId=4},
                new AutomatItem{Id=5,Name="Damla Su",ImagePath="../../../assets/img/automatItems/items-1.jpg",Price=1,CreatedDate=createdDate,IsDeleted=false,CreatedUserId=1,ItemCategoryId=1,AutomatItemInfoId=5},
                new AutomatItem{Id=6,Name="Hamidiye Su",ImagePath="../../../assets/img/automatItems/items-1.jpg",Price=2,CreatedDate=createdDate,IsDeleted=false,CreatedUserId=1,ItemCategoryId=1,AutomatItemInfoId=6},
                new AutomatItem{Id=7,Name="Sandviç",ImagePath="../../../assets/img/automatItems/items-1.jpg",Price=8,CreatedDate=createdDate,IsDeleted=false,CreatedUserId=1,ItemCategoryId=2,AutomatItemInfoId=7},
            };
            modelBuilder.Entity<AutomatItem>().HasData(automatItems);


            #endregion

            #region Menu

            var menu = new Menu[] 
            { 
                new Menu{Id=1,MenuTypeId=1,StudentId=2,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
                new Menu{Id=2,MenuTypeId=2,StudentId=2,CreatedDate=createdDate,CreatedUserId=1,IsDeleted=false},
            };
            modelBuilder.Entity<Menu>().HasData(menu);

            #endregion

            #region SelectedMenuItems

            var selectedMenuItems = new SelectedMenuItems[]
            {
                new SelectedMenuItems{Id=1,MenuId=1,AutomatItemId=1,Count=2,UseDate = new DateTime(2021,06,25).Date,IsDeleted=false,LastStatus=true,CreatedDate=createdDate,CreatedUserId=1,StudentId=1},
                new SelectedMenuItems{Id=2,MenuId=1,AutomatItemId=2,Count=1,UseDate = new DateTime(2021,06,25).Date,IsDeleted=false,LastStatus=true,CreatedDate=createdDate,CreatedUserId=1,StudentId=1},
                new SelectedMenuItems{Id=3,MenuId=1,AutomatItemId=3,Count=1,UseDate = new DateTime(2021,06,25).Date,IsDeleted=false,LastStatus=true,CreatedDate=createdDate,CreatedUserId=1,StudentId=1},
                new SelectedMenuItems{Id=4,MenuId=2,AutomatItemId=7,Count=1,UseDate = new DateTime(2021,06,25).Date,IsDeleted=false,LastStatus=true,CreatedDate=createdDate,CreatedUserId=1,StudentId=1},
                new SelectedMenuItems{Id=5,MenuId=2,AutomatItemId=2,Count=1,UseDate = new DateTime(2021,06,25).Date,IsDeleted=false,LastStatus=true,CreatedDate=createdDate,CreatedUserId=1,StudentId=1},
                new SelectedMenuItems{Id=6,MenuId=2,AutomatItemId=3,Count=1,UseDate = new DateTime(2021,06,25).Date,IsDeleted=false,LastStatus=true,CreatedDate=createdDate,CreatedUserId=1,StudentId=1},
            };
            modelBuilder.Entity<SelectedMenuItems>().HasData(selectedMenuItems);

            #endregion

            #region Transactions

            var transactions = new Transaction[]
            {
                new Transaction{Id=1,ParentId=1,CreatedDate = new DateTime(2021,06,25).Date,IsDeleted=false,StudentId=1,CreatedUserId =1,MenuTypeId =1},
                new Transaction{Id=2,ParentId=1,CreatedDate = new DateTime(2021,06,25).Date,IsDeleted=false,StudentId=2,CreatedUserId =1,MenuTypeId =2},
                new Transaction{Id=3,ParentId=1,CreatedDate = new DateTime(2021,06,25).Date,IsDeleted=false,StudentId=3,CreatedUserId =1,MenuTypeId =1},
                new Transaction{Id=4,ParentId=1,CreatedDate = new DateTime(2021,06,25).Date,IsDeleted=false,StudentId=4,CreatedUserId =1,MenuTypeId =2},
                new Transaction{Id=5,ParentId=1,CreatedDate = new DateTime(2021,06,26).Date,IsDeleted=false,StudentId=1,CreatedUserId =1,MenuTypeId =2},
                new Transaction{Id=6,ParentId=1,CreatedDate = new DateTime(2021,06,26).Date,IsDeleted=false,StudentId=2,CreatedUserId =1,MenuTypeId =2},
            };
            modelBuilder.Entity<Transaction>().HasData(transactions);

            #endregion

            base.OnModelCreating(modelBuilder);
        }


    }
}
