using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternFactoryLib;

namespace PatternFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            StorePizza NYPizza = new NowYorkPizzaStore();
            StorePizza ChicagoPizza = new ChicagoPizzaStore();

            Console.WriteLine(NYPizza.OrderPizza("Сырная").Display());
            Console.WriteLine(ChicagoPizza.OrderPizza("Сырная").Display());

            Console.WriteLine(NYPizza.OrderPizza("Морская").Display());
            Console.WriteLine(ChicagoPizza.OrderPizza("Морская").Display());

            Console.ReadKey();
        }
    }
}
