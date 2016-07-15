using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4_Destructors
{
    class Car
    {
        string color;
        
        public Car() //Constructor
        { }
        
        public Car(string color) //Constructor
        {
            color = "Red"; 
        }
        
        ~Car() //Destructor
        {
            Console.WriteLine("Destroy car ..."); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            Console.ReadLine();
        }
    }
}
