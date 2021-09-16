using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class Transaction:Base, IEntity
    {
        public int StudentId { get; set; }
        public int ParentId { get; set; }
        public int MenuTypeId { get; set; }
        public Student Student { get; set; }
        public Parent Parent{ get; set; }
        public MenuType MenuType{ get; set; }

        public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
        {
            public void Configure(EntityTypeBuilder<Transaction> builder)
            {

            }
        }
    }
}
