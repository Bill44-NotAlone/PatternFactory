using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryLib
{
    public class NowYorkPizzaStore : StorePizza
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type == "Сырная") pizza = new NowYorkStyleCheesePizza();
            if (type == "Пеперонни") pizza = new NowYorkStylePepperoniPizza();
            if (type == "Морская") pizza = new NowYorkStyleClamPizza();
            if (type == "Веганская") pizza = new NowYorkStyleVeggiePizza();
            return pizza;
        }
    }
}
