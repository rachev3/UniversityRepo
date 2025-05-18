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
        public double TotalIncome { get; private set; }
        public List<Order> Orders { get; private set; } = new List<Order>();
        public Dictionary<string, int> PizzaCounts { get; private set; } = new();

        public void AddOrder(Order order)
        {
            Orders.Add(order);
            if (order.Item is Pizza pizza)
            {
                TotalPizzas += pizza.Count;
                if (!PizzaCounts.ContainsKey(pizza.Name))
                    PizzaCounts[pizza.Name] = 0;
                PizzaCounts[pizza.Name] += pizza.Count;
            }
            TotalIncome += order.TotalPrice;
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
