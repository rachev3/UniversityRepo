using Cars.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models
{
    public class Car : BaseModel
    {
        public DateTimeOffset YearOfManufacture {  get; set; }
        public double MaxSpeed { get; set; }
        public double Weight { get; set; }
        public double Lenght { get; set; }

        public int? EngineId { get; set; }
        public Engine? Engine { get; set; }
        public Model? Model { get; set; }
    }
}
