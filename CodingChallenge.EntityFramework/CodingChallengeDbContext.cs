using CodingChallenge.Domain.Models.Models;
using CodingChallenge.EntityFramework.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.EntityFramework
{
    public class CodingChallengeDbContext
        : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TimekeepingTransaction> TimekeepingTransactions { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }

        public CodingChallengeDbContext(
            DbContextOptions<CodingChallengeDbContext> options)
            :base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging(true);
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString =
            "Server=.;Database=CodingChallenge;Integrated Security=true;";

                optionsBuilder.UseSqlServer(connectionString);

            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TimekeepingTransactionEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionTypeEntityTypeConfiguration());


            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                                                    .Where(e => !e.IsOwned())
                                                    .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
