using System;
using System.Collections.Generic;
using System.Text;
using BasicTrader.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace BasicTrader.EntityFramework
{
    public class BasicTraderDbContext: DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<AssetTransaction> AssetTransaction { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetTransaction>().OwnsOne(a=>a.Stock);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Database=BasicTraderDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
