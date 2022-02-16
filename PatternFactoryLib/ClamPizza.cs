using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryLib
{
    public class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            description = "Морская пицца:";
        }

        public override string Cut()
        {
            return "Пицца не нарезана.";
        }
    }
}
