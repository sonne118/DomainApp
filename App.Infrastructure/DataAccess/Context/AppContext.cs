using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.EntityFrameworkCore;
using App.Domain.Model;
using App.Infrastructure.DataAccess.Mapping;

namespace App.Infrastructure.DataAccess.Context
{
    public class AppContex : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<BonusAccount> BonusAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "InMemoryData");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            OnMappingOverride(modelBuilder);
        }

        private void OnMappingOverride(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EntityMappingUser());
            modelBuilder.ApplyConfiguration(new EntityMappingUserAccount());
            modelBuilder.ApplyConfiguration(new EntityMappingPayment());
            modelBuilder.ApplyConfiguration(new EntityMappingBonusAccount());
            modelBuilder.Entity<Payment>()
                        .HasOne(p => p.UserAccount)
                        .WithMany(b => b.Payments)
                        .HasForeignKey(f => f.UserAccountForeingKey)
                        .IsRequired();

            modelBuilder.Entity<BonusAccount>()
                        .HasOne(p => p.UserAccount)
                        .WithMany(b => b.BonusAccounts)
                        .HasForeignKey(f => f.UserAccountForeignKey)
                        .IsRequired();

            modelBuilder.Entity<UserAccount>()
                        .HasOne(p => p.User)
                        .WithMany(b => b.UserAccounts)
                        .HasForeignKey(f => f.UserForeignKey)
                        .IsRequired();

        }
    }
}
