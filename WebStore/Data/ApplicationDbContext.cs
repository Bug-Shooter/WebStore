using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Models.Orders;
using WebStore.Models.Products;
using WebStore.Models.Specs;
using WebStore.Models.Users;

namespace WebStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<OrderList> OrderLists { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<LCategory> LCategories { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Spec> Specs { get; set; }
        public DbSet<SpecList> SpecLists { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
