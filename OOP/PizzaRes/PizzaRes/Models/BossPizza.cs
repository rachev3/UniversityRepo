using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRes.Models
{
    public class BossPizza : Pizza
    {
        public BossPizza(string size, int count) : base(size, count)
        {
            Name = "Boss` Pizza";
            Ingredient = "Ham";
            IngredientQuantity = 100;
            switch (size.ToLower())
            {
                case "small":
                    Price = 20;
                    break;
                case "medium":
                    Price = 25;
                    break;
                case "large":
                    Price = 30;
                    break;
                default:
                    throw new ArgumentException("Invalid size");
            }

        }
    }
}
