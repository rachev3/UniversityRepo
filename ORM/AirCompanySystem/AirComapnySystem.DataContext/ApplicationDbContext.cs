using AirCompanySystem.BaseModels;
using AirCompanySystem.DataContext.Contracts;
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
        public DbSet<Country> Con { get; set; }
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
            //modelBuilder.Entity<Payroll>().HasOne<Ticket>().WithOne(x=>x.Payroll).OnDelete(DeleteBehavior.Cascade);

            //DECORATORS, Interceptors
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            // TODO: 
            //var entries = ChangeTracker.Entries().Where(x=>x.Entity.GetType() is IBaseModel)


            return base.SaveChanges();
        }
    }
}
