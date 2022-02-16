using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryLib
{
    public class NewYorkStyleCheesePizza : Pizza
    {
        public NewYorkStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
        }
        public override string Cut()
        {
            return "Не польностью.";
        }
    }
}
