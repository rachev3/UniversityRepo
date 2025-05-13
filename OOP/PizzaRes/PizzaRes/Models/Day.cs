using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaRes.Interfaces;

namespace PizzaRes.Models
{
    public class Day
    {
        public Day(DateOnly date)
        {
            Date = date;
        }
        public DateOnly Date { get; }
        public int TotalPizzas { get; private set; }
        public int MargaritasCount { get; private set; }
        public int BossPizzasCount { get; private set; }
        public double TotalIncome { get; private set; }
        public List<IOrderItem> Orders { get; private set; } = new List<IOrderItem>();
        public Dictionary<string, int> PizzaCounts { get; private set; } = new();

        public void AddOrder(IOrderItem order)
        {
            Orders.Add(order);
            TotalPizzas += order.Count;
            TotalIncome += order.TotalPrice;

            if (!PizzaCounts.ContainsKey(order.Name))
                PizzaCounts[order.Name] = 0;
            PizzaCounts[order.Name] += order.Count;
        }
        public void Info()
        {
            Console.WriteLine(Date.ToString());
            Console.WriteLine($"Total pizzas: {TotalPizzas}");
            foreach (var kvp in PizzaCounts)
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            Console.WriteLine($"Total income: {TotalIncome}$");
        }
    }
}
