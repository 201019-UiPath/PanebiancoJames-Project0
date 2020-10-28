using Microsoft.EntityFrameworkCore;
using GameKingdomDB.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace GameKingdomDB
{
    public class GameKingdomContext : DbContext
    {
        public DbSet<Customer> Customers {get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!(optionsBuilder.IsConfigured))
            {
                var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

                var connectionString = configuration.GetConnectionString("GameKingdomDB");
                optionsBuilder.UseNpgsql(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasOne(e => e.Customer)
            .WithMany(v => v.Address)
            .HasForeignKey(e => e.CustomerId);

            // additional tables here
        }
    }
}