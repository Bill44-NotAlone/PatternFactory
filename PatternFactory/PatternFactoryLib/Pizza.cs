using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryLib
{
    public class Pizza
    {
        protected string description;
        public string Prepare()
        {
            return "Питцца приготовлениа.";
        }
        public string Bake()
        {
            return "Пицца выпечена.";
        }
        public string Box()
        {
            return "Пицца ушла в синую коробку.";
        }
        public string Cut()
        {
            return "Пицца разрезана.";
        }

        public string Display()
        {
            return $"{description}\n{this.Bake()}\n{this.Prepare()}\n{this.Cut()}\n{this.Box()}";
        }
    }
}
