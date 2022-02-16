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
            StorePizza store = new StorePizza();
            Pizza pizza = store.orderPizza("Сырная");
            Console.WriteLine(pizza.Display());
            Console.WriteLine("===");

            pizza = store.orderPizza("Веганская");
            Console.WriteLine(pizza.Display());
            Console.WriteLine("===");

            pizza = store.orderPizza("Морская");
            Console.WriteLine(pizza.Display());
            Console.WriteLine("===");

            pizza = store.orderPizza("Пеперони");
            Console.WriteLine(pizza.Display());
            Console.WriteLine("===");

            Console.ReadLine();
        }
    }
}
