using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryLib
{
    public abstract class Pizza
    {
        public string Name;
        public Dough dough;
        public Sauce sauce;
        public Cheese cheese;
        public Clams clam;

        public abstract void Prepare();
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
            string description = Name + "\n";
            if (dough != null) description = description + dough.Name + "\n";
            if (sauce != null) description = description + sauce.Name + "\n";
            if (cheese != null) description = description + cheese.Name + "\n";
            if (clam != null) description = description + clam.Name + "\n";
            return description;
        }
    }
}
