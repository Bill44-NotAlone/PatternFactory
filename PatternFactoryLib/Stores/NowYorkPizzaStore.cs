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
            IPizzaIngredientFactory factory = new NewYorkPizzaIngredientFactory();
            switch (type)
            {
                case "Сырная": 
                    pizza = new CheesePizza(factory);
                    pizza.Name = "Сырная в Нью-Ержском стиле.\n";
                    break;
                case "Морская": 
                    pizza = new ClamPizza(factory);
                    pizza.Name = "Морская в Нью-Ержском стиле.\n";
                    break;
                default: break;
            }
            return pizza;
        }
    }
}
