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
            IPizzaIngredientFactory factory = new ChicagoPizzaIngredientFactory();
            switch (type)
            {
                case "Сырная": 
                    pizza = new CheesePizza(factory);
                    pizza.Name = "Сырная в Чикаго стиле.\n";
                    break;
                case "Морская": 
                    pizza = new ClamPizza(factory);
                    pizza.Name = "Морская в Чикаго стиле.\n";
                    break;
                default: break;
            }

            return pizza;
        }
    }
}
