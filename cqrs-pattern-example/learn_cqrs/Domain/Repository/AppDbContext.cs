using learn_cqrs.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learn_cqrs.Domain.Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "paul", Age = 63 },
                  new User { Id = 2, Name = "Michel", Age = 33 },
                   new User { Id = 3, Name = "Eugene", Age = 21 }
            );
            modelBuilder.Entity<User>().Property(p => p.Id).ValueGeneratedOnAdd();
        }
    }
}
