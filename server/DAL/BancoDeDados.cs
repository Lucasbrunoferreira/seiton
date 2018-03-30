using Microsoft.EntityFrameworkCore;
using BancoDeDados.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace BancoDeDados
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Serie> Series { get; set; }
        public DbSet<Line> Line { get; set; }
        public DbSet<Sector> Sector { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<Contribuitor> Contribuitor { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductSale> ProductSale { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(
            "server=localhost; " +
            "port=3306;" +
            "userid=root;" +
            "password=root; " +
            "database=seitonserver;");
        }
    }
}
