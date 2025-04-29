using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRes.Models
{
    public class Day
    {
        public Day(DateOnly date)
        {
            Date = date;
        }
        public DateOnly Date { get;}
        public int TotalPizzas { get; private set; }
        public int MargaritasCount { get; private set; }
        public int BossPizzasCount { get; private set; }
        public double TotalIncome { get; private set; }
        public List<Order> Orders { get; private set; } = new List<Order>();

        public void AddOrder(Order order)
        {
            Orders.Add(order);
            TotalPizzas += order.Count;
            TotalIncome += (double)order.TotalPrice;
            if (order.Pizza is MargaritaPizza)
            {
                MargaritasCount += order.Count;
            }
            else if (order.Pizza is BossPizza)
            {
                BossPizzasCount += order.Count;
            }
        }
        public void Info()
        {
            Console.WriteLine(Date.ToString());
            Console.WriteLine($"Total pizzas: {TotalPizzas}");
            Console.WriteLine($"Margarita: {MargaritasCount}");
            Console.WriteLine($"Boss` Pizza: {BossPizzasCount}");
            Console.WriteLine($"Total income: {TotalIncome}$");
        }
    }
}
