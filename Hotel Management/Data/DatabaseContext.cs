using Hotel_Management.Data.Seeders;
using Hotel_Management.Models;
using Hotel_Management.Seeders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Hotel_Management.Data
{
    class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomType> RoomType { get; set; }
        public DbSet<Payment> Payment { get; set; }

        public DbSet<Reservation> Reservation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=hotel_management;User=root;Password=;",
                new MySqlServerVersion(new Version(8, 0, 27)));
            optionsBuilder.EnableSensitiveDataLogging();// Adjust the MySQL version
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RoomType>().HasData(
                new RoomType { Id = 1, Name = "Single", Description = "A single room for one person." },
                new RoomType { Id = 2, Name = "Double", Description = "A double room for two people." },
                new RoomType { Id = 3, Name = "Suite", Description = "A luxury suite for families or VIPs." }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "admin",
                    LastName = "admin",
                    PhoneNumber = "0600000000",
                    Email = "admin@hotel.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("admin@123"), // Replace with hashed password in real apps
                    Role = UserRole.Admin
                }

            );

            modelBuilder.Entity<Reservation>()
            .HasOne(r => r.Client)
            .WithMany()
            .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Room)
                .WithMany()
                .HasForeignKey(r => r.RoomId);

            var users = UserSeeder.Seed(25);
            modelBuilder.Entity<User>().HasData(users);

            var rooms = RoomSeeder.Seed(50);
            modelBuilder.Entity<Room>().HasData(rooms);

            var reservations = ReservationSeeder.Seed(100, 10, 50);
            modelBuilder.Entity<Reservation>().HasData(reservations);

            var payments = PaymentSeeder.Seed(80, 100);
            modelBuilder.Entity<Payment>().HasData(payments);
        }
    }
}
