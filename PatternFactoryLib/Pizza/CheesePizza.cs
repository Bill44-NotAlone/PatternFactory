using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryLib
{
    public class CheesePizza : Pizza
    {
        private IPizzaIngredientFactory factory;
        public CheesePizza(IPizzaIngredientFactory factory)
        {
            this.factory = factory;
        }
        public override void Prepare()
        {
            dough = factory.CreateDough();
            cheese = factory.CreateCheese();
            sauce = factory.CreateSauce();
        }
    }
}
