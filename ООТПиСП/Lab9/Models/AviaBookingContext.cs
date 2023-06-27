using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Models
{
    public class AviaBookingContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Указываем строку подключения к базе данных
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Lab9OOP;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Flight)
                .WithMany(f => f.Customers)
                .HasForeignKey(c => c.FlightNumber)
                .OnDelete(DeleteBehavior.Restrict);
        }


    }


}
