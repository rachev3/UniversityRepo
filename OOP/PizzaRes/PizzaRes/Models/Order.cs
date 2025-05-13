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
        public Order(IOrderItem item, int count, DateOnly date)
        {
            Item = item;
            Count = count;
            Date = date;
        }
        public IOrderItem Item { get; }
        public int Count { get; }
        public double TotalPrice => Count * Item.Price;
        public DateOnly Date { get; }

        public void Info()
        {
            Console.WriteLine($"{Item.Name} preparing...");
            Item.Info();
            Console.WriteLine($"Total: {TotalPrice}$");
        }
    }
}
