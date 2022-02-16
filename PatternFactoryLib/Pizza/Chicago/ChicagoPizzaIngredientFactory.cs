using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryLib
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new MozzarellaCheese() { Name = "MozzarellaCheese" };
        }

        public Clams CreateClam()
        {
            return new FrozenClams() { Name = "FrozenClams" };
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough() { Name = "ThickCrustDough" };
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce() { Name = "PlumTomatoSauce" };
        }
    }
}
