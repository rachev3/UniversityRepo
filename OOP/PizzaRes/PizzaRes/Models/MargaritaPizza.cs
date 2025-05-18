using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRes.Models
{
    public class MargaritaPizza : Pizza
    {
        public MargaritaPizza(string size, int count) : base(size, count)
        {
            Name = "Pizza Margarita";
            Ingredient = "Tomato";
            IngredientQuantity = 1;
            switch (size.ToLower())
            {
                case "small":
                    Price = 5;
                    break;
                case "medium":
                    Price = 10;
                    break;
                case "large":
                    Price = 15;
                    break;
                default:
                    throw new ArgumentException("Invalid size");
            }
        }
    }
}
