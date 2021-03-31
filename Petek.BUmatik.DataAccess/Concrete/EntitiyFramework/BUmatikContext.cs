using Microsoft.EntityFrameworkCore;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.DataAccess.Concrete.EntitiyFramework
{
    public class BUmatikContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseNpgsql(@"User ID=postgres;Password=1;Server=127.0.0.1;Port=5432;Database=BUmatik;Integrated Security=true;Pooling=true;");
        }
        public DbSet<Student> Students { get; set; }
        //public DbSet<Parent> Parents{ get; set; }
        //public DbSet<School> Schools{ get; set; }
    }
}
