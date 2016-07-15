using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_23_base_and_this_keywords
{
    // base class
    public class Bird
    {
        public string Genus { get; private set; }

        public Bird()
        {
            Genus = "bird";
        }

        public Bird(string Genus)
        {
            Console.WriteLine("Inside Bird constructor");
            this.Genus = Genus;
        }
        
        public void Fly() 
        {
            Console.WriteLine("I'm flying...");
        }
        public void Voice ()
        {
            Console.WriteLine("Bird is singing...");
        }
    }

    class Duck : Bird
    {
        public Duck(string genus)
            : base(genus)
        {
            Console.WriteLine("Inside Duck constructor");
        }

        public void Voice()
        {
            base.Voice();
            Console.WriteLine("Duck says kra-kra...");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck("duck");
            
            duck.Voice();
        }
    }
}
