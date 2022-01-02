using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Attribute = DataAccess.Entity.Attribute;

namespace DataAccess.Context
{
    public class InventoryContext:DbContext
    {
        public DbSet<Brand> brands { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Store> stores { get; set; }

        public DbSet<Attribute> attributes { get; set; }
        public DbSet<AttributeValue> attributeValues { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<Currency> currencies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=InventorySystem;Integrated Security=True");
            base.OnConfiguring(optionsBuilder); 
        }
    }
}
