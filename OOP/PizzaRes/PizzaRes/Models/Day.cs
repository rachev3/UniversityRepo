using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRes.Models
{
    public class Day
    {
        public DateTimeOffset Date { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
