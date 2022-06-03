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
            new Team(1, "Mercedes", 1954, 8, true),
            new Team(2, "Ferrari", 1950, 16, true),
            new Team(3, "Red Bull", 2005, 4, true),
            new Team(4, "McLaren", 1966, 8, true),
            new Team(5, "Alpine", 2021, 0, true),
            new Team(6, "Haas", 2016, 0, true),
            new Team(7, "Aston Martin", 1959, 0, true),
            new Team(8, "Alpha Tauri", 2020, 0, true),
            new Team(9, "Alfa Romeo", 1950, 0, true),
            new Team(10, "Williams", 1978, 9, true)
        };

            modelBuilder.Entity<Team>().HasData(teams);
        }
    }
}
