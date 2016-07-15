using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_28_IClonable
{
    class Program
    {
        public class Bird : ICloneable
        {
            public string Genus { get; set; }
            public Bird(string genus)
            {
                this.Genus = genus;
            }

            public object Clone()
            {
                Bird bird = new Bird(this.Genus);
                return bird;
            }
        }

        static void Main(string[] args)
        {
            Bird bird1 = new Bird("Chicken");
            Bird bird2 = (Bird)bird1.Clone();
        }
    }
}
