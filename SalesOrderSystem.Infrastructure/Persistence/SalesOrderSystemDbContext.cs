using Microsoft.EntityFrameworkCore;
using SalesOrderSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderSystem.Infrastructure.Persistence
{
    public class SalesOrderSystemDbContext : DbContext
    {
        public SalesOrderSystemDbContext(DbContextOptions<SalesOrderSystemDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products  { get; set; }
        public DbSet<Order> orders { get; set; } 
        public DbSet<OrderItem> ordersItem { get; set; }

    }
}
