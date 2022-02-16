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
            if (type == "Сырная") pizza = new NewYorkStyleCheesePizza();
            if (type == "Пеперонни") pizza = new NewYorkStylePepperoniPizza();
            if (type == "Морская") pizza = new NewYorkStyleClamPizza();
            if (type == "Веганская") pizza = new NewYorkStyleVeggiePizza();
            return pizza;
        }
    }
}
