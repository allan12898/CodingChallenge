using CodingChallenge.Domain.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.EntityFramework.EntityConfiguration
{
    public class EmployeeEntityTypeConfiguration
        : IEntityTypeConfiguration<Employee>
    {


        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();

            builder.HasMany(c => c.TimekeepingTransaction);
        }
    }
}
