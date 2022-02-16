using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryLib
{
    public class NewYorkPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese() { Name = "ReggianoCheese" };
        }

        public Clams CreateClam()
        {
            return new FreshClams() { Name = "FreshClams" };
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough() { Name = "ThinCrustDough" };
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce() { Name = "MarinaraSauce" };
        }
    }
}
