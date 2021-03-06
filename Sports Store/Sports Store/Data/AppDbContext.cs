﻿using Microsoft.EntityFrameworkCore;
using Sports_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Store.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasIndex(x => x.Name);
            modelBuilder.Entity<Product>().HasIndex(x => x.PurchasePrice);
            modelBuilder.Entity<Product>().HasIndex(x => x.RetailPrice);
            modelBuilder.Entity<Category>().HasIndex(x => x.Name);
            modelBuilder.Entity<Category>().HasIndex(x => x.Description);
        }
    }
}
