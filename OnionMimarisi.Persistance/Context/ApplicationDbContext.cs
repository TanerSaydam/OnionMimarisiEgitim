using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnionMimarisi.Domain.Entities;
using OnionMimarisi.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Persistance.Context
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FullAddress> FullAddresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ShipInfo> ShipInfos { get; set; }

    }
}
