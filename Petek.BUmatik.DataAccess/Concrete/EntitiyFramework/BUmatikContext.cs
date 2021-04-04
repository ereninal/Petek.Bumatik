using Microsoft.EntityFrameworkCore;
using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Text;
using Petek.BUmatik.Shared.Constants;

namespace Petek.BUmatik.DataAccess.Concrete.EntitiyFramework
{
    public class BUmatikContext : DbContext
    {
       
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(PostgreDb.ConnectionStringLocal);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Parent> Parents{ get; set; }
        public DbSet<School> Schools{ get; set; }
    }
}
