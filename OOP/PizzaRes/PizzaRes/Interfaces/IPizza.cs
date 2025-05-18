using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRes.Interfaces
{
    public interface IPizza
    {
        public string Name { get; }
        public string Size { get; }
        public int Dough { get; }
        public double Price { get; }
        public string Ingredient { get; }
        public int IngredientQuantity { get; }
    }
}
