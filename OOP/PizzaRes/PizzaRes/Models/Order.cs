using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRes.Models
{
    public class Order
    {
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
    }
}
