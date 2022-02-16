using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryLib
{
    public class ChicagoPizzaStore : StorePizza
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type == "Сырная") pizza = new ChicagoStyleCheesePizza();
            if (type == "Пеперонни") pizza = new ChicagoStylePepperoniPizza();
            if (type == "Морская") pizza = new ChicagoStyleClamPizza();
            if (type == "Веганская") pizza = new ChicagoStyleVeggiePizza();

            return pizza;
        }
    }
}
