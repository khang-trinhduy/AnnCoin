using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AnnConn.Models
{
    public class AnnContext : DbContext
    {
        public AnnContext (DbContextOptions<AnnContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Collaborators>()
                .HasMany(c => c.contracts)
                .WithOne();
            modelBuilder.Entity<Collaborators>()
               .HasMany(c => c.customers)
               .WithOne();
        }

        public DbSet<AnnConn.Models.Customers> Customers { get; set; }
        public DbSet<Collaborators> Collaborators { get; set; }
        public DbSet<Contracts> Contracts { get; set; }
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Sale> sale { get; set; }
        public DbSet<Appoinment> appoinment { get; set; }
    }
}
