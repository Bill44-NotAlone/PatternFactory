using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryLib
{
    public class DependentStorePizza
    {
        public Pizza OrderPizza(string style,string type)
        {
            Pizza pizza = CreatePizza(style,type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
        public Pizza CreatePizza(string style, string type)
        {
            Pizza pizza = null;
            switch (style)
            {
                case "NewYork":
                    if (type == "Сырная") pizza = new NewYorkStyleCheesePizza();
                    if (type == "Пеперонни") pizza = new NewYorkStylePepperoniPizza();
                    if (type == "Морская") pizza = new NewYorkStyleClamPizza();
                    if (type == "Веганская") pizza = new NewYorkStyleVeggiePizza();
                    break;

                case "Chicago":
                    if (type == "Сырная") pizza = new ChicagoStyleCheesePizza();
                    if (type == "Пеперонни") pizza = new ChicagoStylePepperoniPizza();
                    if (type == "Морская") pizza = new ChicagoStyleClamPizza();
                    if (type == "Веганская") pizza = new ChicagoStyleVeggiePizza();
                    break;
            }
            return pizza;
        }
    }
}
