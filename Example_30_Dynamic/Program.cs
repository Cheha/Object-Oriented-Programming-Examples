using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_30_Dynamic
{
    public class Bird
    {
        public Bird(string Genus)
        {
            this.Genus = Genus;
        }
        public string Genus { get;private set; }
        public void Fly() { }
        public virtual void Voice3 ()
        {
            Console.WriteLine("Bird is singing...");
        }
     }

    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird("Duck");

            dynamic bird2 = bird;
            bird2.Voice("Duck");
            var bird3 = bird2;
            Type tt = bird3.GetType();
            Console.WriteLine("bird3 type is: {0}", tt.ToString());

        }
    }
}
