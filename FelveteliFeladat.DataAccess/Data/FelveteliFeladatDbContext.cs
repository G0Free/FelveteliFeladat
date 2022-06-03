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
            new Team(1, "Mercedes", 1967, 10, true),
            new Team(2, "Ferrari", 1967, 40, true),
            new Team(3, "Red Bull", 1967, 8, true),
            new Team(4, "McLaren", 1967, 3, true),
            new Team(5, "Alpine", 1967, 3, true),
            new Team(6, "Haas", 1967, 0, true),
            new Team(7, "Aston Martin", 1967, 0, true),
            new Team(8, "Alpha Tauri", 1967, 0, true),
            new Team(9, "Alfa Romeo", 1967, 1, true),
            new Team(10, "Williams", 1967, 6, true)
        };

            modelBuilder.Entity<Team>().HasData(teams);
        }
    }
}
