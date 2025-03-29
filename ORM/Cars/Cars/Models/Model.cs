using Cars.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models
{
    public class Model : BaseModel
    {
        public string Name { get; set; }
        public int? CarId { get; set; }
        public Car? Car { get; set; }

    }
}
