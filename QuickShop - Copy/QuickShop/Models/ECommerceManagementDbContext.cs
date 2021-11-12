using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuickShop.Models;

namespace QuickShop.Models
{
    public class ECommerceManagementDbContext : DbContext
    {
        public ECommerceManagementDbContext(DbContextOptions<ECommerceManagementDbContext> options)
        : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        
    }
}
