using AirCompanySystem.BaseModels;
using AirCompanySystem.DataContext.Contracts;
using AirCompanySystem.DataContext.Seed;
using AirCompanySystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirComapnySystem.DataContext
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightStatus> FlightStatuses { get; set; }
        public DbSet<FlightStatusChange> FlightStatusChanges { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LENOVO-GAMING;Database=AirCompanySystem;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure one-to-many relationship between Passenger and Ticket
            modelBuilder.Entity<Passenger>()
                .HasMany(p => p.Tickets)
                .WithOne(t => t.Passenger)
                .HasForeignKey(t => t.PassengerId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure one-to-one relationship between Ticket and Payroll
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Payroll)
                .WithOne(p => p.Ticket)
                .HasForeignKey<Payroll>(p => p.TicketId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure many-to-one relationship between Payroll and Passenger
            modelBuilder.Entity<Payroll>()
                .HasOne(p => p.Passenger)
                .WithMany()
                .HasForeignKey(p => p.PassengerId)
                .OnDelete(DeleteBehavior.NoAction); // Using NoAction to avoid circular cascade delete

            DataSeed.ExampleSeed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}