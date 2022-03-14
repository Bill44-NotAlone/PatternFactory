using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryLib
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            description = "Сырная пицца:";
        }

        public new string Box()
        {
            return "Пицца вложена в желтую каробку.";
        }

        public override string Cut()
        {
            return "Пицца разрезана на 5 долей.";
        }
    }
}
