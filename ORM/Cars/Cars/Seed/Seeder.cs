using Cars.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Seed
{
    public class Seeder
    {
        private static List<Car> carsList = new List<Car>()
        {
            new Car()
            {
               YearOfManufacture = new DateTimeOffset(new DateTime(2006, 3, 15)),
               MaxSpeed = 210,
               Weight = 1280,
               Lenght = 4200,
               EngineId = enginesList[0].Id,
            },
            new Car
            {
                YearOfManufacture = new DateTimeOffset(new DateTime(2015, 7, 22)),
                MaxSpeed = 250,
                Weight = 1420,
                Lenght = 4700,
                EngineId = enginesList[1].Id,
            },
            new Car
            {
                Id = 3,
                YearOfManufacture = new DateTimeOffset(new DateTime(2020, 5, 10)),
                MaxSpeed = 180,
                Weight = 1340,
                Lenght = 4350,
                EngineId = enginesList[2].Id,
            }
        };

        private static List<Engine> enginesList = new List<Engine>()
        {
            new Engine()
            {
                Name = "BMW N45B16",
                Power = 90,
                HorsePowers = 122,
                FuelType = "Petrol"

            },
            new Engine
            {
                Id = 2,
                Name = "Audi 2.0 TDI",
                Power = 110,
                HorsePowers = 150,
                FuelType = "Diesel"
            },
            new Engine
            {
                Id = 3,
                Name = "Toyota 1.8 VVT-i Hybrid",
                Power = 72,
                HorsePowers = 122,
                FuelType = "Hybrid"
            }
        };

        private static List<Model> modelsList = new List<Model>()
        {
            new Model
            {
                Name = "BMW 116i",
                CarId = carsList[0].Id
            },
            new Model
            {
                Name = "Audi A4",
                CarId = carsList[1].Id
            },
            new Model
            {
                Name = "Toyota Corolla",
                CarId = carsList[2].Id
            }
        };

        public static void ExampleSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Engine>().HasData(enginesList);
            modelBuilder.Entity<Model>().HasData(modelsList);
            modelBuilder.Entity<Car>().HasData(carsList);
        }
    }
}
