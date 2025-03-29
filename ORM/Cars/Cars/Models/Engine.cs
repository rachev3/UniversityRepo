using Cars.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models
{
    public class Engine: BaseModel
    {
        public string Name { get; set; } 
        public int Power { get; set; }
        public int HorsePowers { get; set; }
        public string FuelType { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
