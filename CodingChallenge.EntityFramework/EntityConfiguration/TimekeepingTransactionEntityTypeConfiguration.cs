using CodingChallenge.Domain.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.EntityFramework.EntityConfiguration
{
    public class TimekeepingTransactionEntityTypeConfiguration
        : IEntityTypeConfiguration<TimekeepingTransaction>
    {
        public void Configure(EntityTypeBuilder<TimekeepingTransaction> builder)
        {
            builder.ToTable("TimekeepingTransactions");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();
            builder.HasKey(cr => new { cr.EmployeeId, cr.TransactionTypeId });

            builder.Property(c => c.EmployeeId).IsRequired();
            builder.Property(c => c.TransactionTypeId).IsRequired();

            builder.HasOne(c => c.Employee).WithMany(c => c.TimekeepingTransaction).HasForeignKey("EmployeeId");
            builder.HasOne(c => c.TransactionType).WithMany(c => c.TimekeepingTransaction).HasForeignKey("TransactionTypeId");
        }
    }
}
