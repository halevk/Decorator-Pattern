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
            //simple pizza
            var vegPizza = new VegeterianPizza();

            // extras
            var mush = new PizzaWithMushroom("Mushroom", 20, vegPizza);
            var pep = new PizzaWithPeproni("Red Peperoni", 10, mush);
            var ced = new PizzaWithCheddarChesee("Cheddar cheese extra", 5, pep);
            
            Console.WriteLine("Total price of order : {0} TL", ced.Price);
            Console.WriteLine("Pizza ordered : {0}",ced.Name);

            Console.ReadLine();

        }
    }
}
