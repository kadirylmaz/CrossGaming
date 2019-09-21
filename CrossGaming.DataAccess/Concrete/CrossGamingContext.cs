using CrossGaming.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CrossGaming.DataAccess.Concrete
{
    public class CrossGamingContext:DbContext
    {
        public CrossGamingContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();

            //var connectionString = configuration.GetConnectionString("ConnectionString");
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-4IMGOMO\KADIR; Database=CrossGaming; Integrated security=true;");
            base.OnConfiguring(optionsBuilder);
        }




        public DbSet<Player> Players { get; set; }
        public DbSet<Bot> Bots { get; set; }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Match> MAt { get; set; }


    }
}
