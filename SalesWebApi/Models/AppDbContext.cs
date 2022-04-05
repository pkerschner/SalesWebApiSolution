using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApi.Models {

    public class AppDbContext : DbContext {
        // properties
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Orderline> Orderlines { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        // constructor
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
        // to use fluent api
        protected override void OnModelCreating(ModelBuilder builder) {
        }
    }
}
