using ddd.domain.dbentity;
using ddd.domain.Interfaces;
using ddd.insfrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.Implements
{
    public class BalanceEFCoreContext : DbContext
    {
        public DbSet<BalanceInfo> BalanceInfo { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        //{
        //    optionBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Balance;Trusted_Connection=True;");
        //}
        public BalanceEFCoreContext(DbContextOptions<BalanceEFCoreContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BalanceInfo>().OwnsOne(p => p.PersonInfo);
            modelBuilder.Entity<BalanceInfo>().OwnsOne(p => p.MoneyInfo);
        }
    }
}
