using PizzaRes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRes.Models
{
    public abstract class Pizza : IPizza, IOrderItem
    {
        protected Pizza(string size, int count)
        {
            Size = size;
            Count = count;
            SetDough();
        }

        public string Name { get; protected set; }
        public string Size { get; private set; }
        public int Dough { get; private set; }
        public double Price { get; protected set; }
        public string Ingredient { get; protected set; }
        public int IngredientQuantity { get; protected set; }

        public int Count { get; set; }

        public void Info()
        {
            Console.WriteLine($"Pizza dough {Count}*{Dough} = {Dough * Count}g");
            Console.WriteLine($"{Ingredient}*{IngredientQuantity} = {IngredientQuantity * Count}");
        }

        private void SetDough()
        {
            switch (Size?.ToLower())
            {
                case "small":
                    Dough = 300;
                    break;
                case "medium":
                    Dough = 500;
                    break;
                case "large":
                    Dough = 800;
                    break;
                default:
                    throw new ArgumentException("Invalid pizza size.");
            }
        }
    }
}
