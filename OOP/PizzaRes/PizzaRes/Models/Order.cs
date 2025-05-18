using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaRes.Interfaces;

namespace PizzaRes.Models
{
    public class Order
    {
        public Order(IOrderItem item, DateOnly date)
        {
            Item = item;
            Date = date;
        }
        public IOrderItem Item { get; }
        public DateOnly Date { get; }
        public double TotalPrice => Item.Price * Item.Count;

        public void Info()
        {
            Console.WriteLine($"{Item.Name} preparing...");
            Item.Info();
            Console.WriteLine($"Total: {TotalPrice}$");
        }
    }
}
