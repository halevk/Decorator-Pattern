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
           
            Pizza veg = new VegiPizza() {Price = 10};
            veg=new ExtraMushroom(veg);
            veg = new ExtraOlive(veg);

            var price = veg.GetPrice();

            Console.WriteLine("Total Price {0} $",price);

            Console.ReadLine();

        }
    }
}
