using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_21_Inheritance
{
    class Bird
    {
        public string Genus
        {
            get;
            set;
        }

        public Bird() 
        {
            Genus = "Bird";
            Console.WriteLine("Bird initialized");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }

    class Duck : Bird
    {
        public void Swim()
        {
            Console.WriteLine("I'm swimming");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck();
            duck.Swim();
            duck.Fly();
            Console.ReadLine();
        }
    }
}
