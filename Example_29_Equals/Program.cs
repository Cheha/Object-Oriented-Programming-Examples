using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_29_Equals
{
    public class Bird : ICloneable
    {
        public string Genus { get; set; }
        public Bird(string genus)
        {
            this.Genus = genus;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) 
            {
                return false;
            }

            Bird bird2 = (Bird)obj;
            return this.Genus == bird2.Genus;
        }

        public object Clone()
        {
            Bird bird = new Bird(this.Genus);
            return bird;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bird bird1 = new Bird("Duck");
            Bird bird2 = (Bird)bird1.Clone();

            bool areEqual = bird1.Equals(bird2);
            Console.WriteLine("Are objects equal: {0}", areEqual);

            Console.WriteLine(bird2.ToString());

            Type type = bird1.GetType();
            int hashcode = bird2.GetHashCode();
        }
    }
}
