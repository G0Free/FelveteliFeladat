using FelveteliFeladat.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelveteliFeladat.DataAccess.Data
{
    public class FelveteliFeladatDbContext : DbContext
    {
        public virtual DbSet<Team> MyProperty { get; set; }
        public FelveteliFeladatDbContext()
        {

        }
        public FelveteliFeladatDbContext(DbContextOptions<FelveteliFeladatDbContext> options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseInMemoryDatabase("database")
                    .UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Team[] teams = new Team[]
            {
            new Team("Mercedes", 1967, 10, true),
            new Team("Ferrari", 1967, 40, true),
            new Team("Red Bull", 1967, 8, true),
            new Team("McLaren", 1967, 3, true),
            new Team("Alpine", 1967, 3, true),
            new Team("Haas", 1967, 0, true),
            new Team("Aston Martin", 1967, 0, true),
            new Team("Alpha Tauri", 1967, 0, true),
            new Team("Alfa Romeo", 1967, 1, true),
            new Team("Williams", 1967, 6, true)
        };

            modelBuilder.Entity<Team>().HasData(teams);
        }
    }
}
