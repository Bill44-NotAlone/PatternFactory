using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryLib
{
    public abstract class Pizza
    {
        protected string description;
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public virtual string Prepare()
        {
            return "Питцца приготовлениа.";
        }
        public virtual string Bake()
        {
            return "Пицца выпечена.";
        }
        public virtual string Box()
        {
            return "Пицца ушла в синую коробку.";
        }
        public virtual string Cut()
        {
            return "Пицца разрезана.";
        }
        public string Display()
        {
            return $"{description}\n{this.Bake()}\n{this.Prepare()}\n{this.Cut()}\n{this.Box()}";
        }
        public string GetName()
        {
            return name;
        }
    }
}
