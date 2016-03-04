using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegPizza = new VegeterianPizza();

            var mush = new PizzaWithMushroom("mushroom", 20, vegPizza);
            var pep = new PizzaWithPeproni("REd Peperoni", 10, mush);
            var ced = new PizzaWithCheddarChesee("Cheddar chesee extra", 5, pep);

            Console.WriteLine(ced.Price);
            Console.WriteLine(ced.Name);

        }
    }
}
