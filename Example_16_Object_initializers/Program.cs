using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_16_Object_initializers
{
    class MyClass
    {
        public int Property1 { get; set; }
        public string Property2 { get; set; }
        public MyClass() { }

        public MyClass(int x, string y)
        {
            Property1 = x;
            Property2 = y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject1 = new MyClass { Property1 = 6, Property2 = "Text" };
            MyClass myObject2 = new MyClass() { Property1 = 6, Property2 = "Text" };

            MyClass myObject3 = new MyClass(4, "Constructot Text") { Property1 = 6, Property2 = "Text" };
            Console.WriteLine("myObject3 Property1: {0}", myObject3.Property1);
            Console.WriteLine("myObject3 Property2: {0}", myObject3.Property2);

            Console.ReadLine();
        }
    }
}
