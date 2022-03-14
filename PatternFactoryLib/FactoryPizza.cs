using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryLib
{
    public class FactoryPizza
    {
        public static Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if(type == "Сырная") pizza = new CheesePizza();
            if(type == "Веганская") pizza = new VeggiePizza();
            if(type == "Морская") pizza = new ClamPizza();
            if (type == "Пеперони") pizza = new PepperoniPizza();

            return pizza;
        }
    }
}
