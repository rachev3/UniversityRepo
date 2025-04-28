using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRes.Interfaces
{
    public interface Pizza
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
    }
}
