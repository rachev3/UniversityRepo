using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRes.Models
{
    public class Order
    {
        public Order(Pizza pizza, int count, DateOnly date)
        {
            Pizza = pizza;
            Count = count;
            Date = date;
        }
        public Pizza Pizza { get; }
        public int Count { get; }
        public double TotalPrice => Count * Pizza.Price;
        public DateOnly Date { get; }

        public void Info()
        {
            Console.WriteLine($"{Pizza.Name} preparing...");
            Console.WriteLine($"Pizza dough {Count}*{Pizza.Dough} = {Count*Pizza.Dough}");
            Console.WriteLine($"{Pizza.Ingredient} {Count}*{Pizza.IngredientQuantity} = {Count*Pizza.IngredientQuantity}");
            Console.WriteLine($"Total: {TotalPrice}$");
        }

    }
}
