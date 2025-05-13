using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRes.Interfaces
{
    public interface IOrderItem
    {
        string Name { get; }
        double Price { get; }
        void Info();
    }
}
