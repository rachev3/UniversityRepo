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
        protected Pizza(string size)
        {
            Size = size;
            SetDough();
        }

        public string Name { get; protected set; }
        public string Size { get; private set; }
        public int Dough { get; private set; }
        public double Price { get; protected set; }
        public string Ingredient { get; protected set; }
        public int IngredientQuantity { get; protected set; }
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
