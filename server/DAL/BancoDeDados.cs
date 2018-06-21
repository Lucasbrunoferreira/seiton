using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace BancoDeDados
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Line> Line { get; set; }
        public DbSet<Sector> Sector { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<Contribuitor> Contribuitor { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductSale> ProductSale { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductSale>()
                .HasKey(ps => new { ps.IdProduct, ps.IdSale });

            modelBuilder.Entity<ProductSale>()
                .HasOne(bc => bc.Sale)
                .WithMany(b => b.ProductSales)
                .HasForeignKey(bc => bc.IdSale);

            modelBuilder.Entity<ProductSale>()
                .HasOne(bc => bc.Product)
                .WithMany(c => c.ProductSales)
                .HasForeignKey(bc => bc.IdProduct);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(
            "server=localhost; " +
            "port=3300;" +
            "userid=root;" +
            "password=root; " +
            "database=seitonserver;");
        }
    }
}
