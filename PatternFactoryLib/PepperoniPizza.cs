using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryLib
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            description = "Пеперони:";
        }

        public override string Cut()
        {
            return "Пицца разрезана на 8 долей.";
        }
    }
}
