using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_24_Polymorphism
{
    public class Bird
    {
        public virtual void Voise()
        {
            Console.WriteLine("Birs is singing...");
        }
    }

    public class Duck : Bird
    {
        public override void Voise()
        {
            Console.WriteLine("Duck says kra kra kra...");
        }
    }

    public class Chiken : Bird
    {
        public override void Voise()
        {
            Console.WriteLine("Chicken says ko ko ko...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Duck();
            bird.Voise();
            Console.ReadLine();
        }
    }
}
