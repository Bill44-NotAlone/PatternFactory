using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryLib
{
    public class ClamPizza : Pizza
    {
        private IPizzaIngredientFactory factory;

        public ClamPizza(IPizzaIngredientFactory factory)
        {
            this.factory = factory;
        }

        public override void Prepare()
        {
            dough = factory.CreateDough();
            sauce = factory.CreateSauce();
            cheese = factory.CreateCheese();
            clam = factory.CreateClam();
        }
    }
}
