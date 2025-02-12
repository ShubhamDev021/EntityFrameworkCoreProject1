﻿using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreProject1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                new Currency() { Id = 1, Title = "INR", Description = "Indian INR" },
                new Currency() { Id = 2, Title = "USD", Description = "USD($)" },
                new Currency() { Id = 3, Title = "Euro", Description = "Euro" },
                new Currency() { Id = 4, Title = "Dinar", Description = "Dinar" }
            );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = 1, Title= "Hindi", Description = "Hindi" },
                new Language() { Id = 2, Title= "Punjabi", Description = "Punjabi" },
                new Language() { Id = 3, Title= "Tamil", Description = "Tamil" },
                new Language() { Id = 4, Title= "Urdu", Description ="Urdu" }
            );
        }

        //To inform DB Context to use the table in Entity Framework Core, use DbSet property as below
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
    }
}
