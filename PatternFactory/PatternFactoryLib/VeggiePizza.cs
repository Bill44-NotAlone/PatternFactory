using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryLib
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            description = "Веганская пицца:";
        }
        public override string Cut()
        {
            return "Пицца разрезана прямоугольниками.";
        }
    }
}
