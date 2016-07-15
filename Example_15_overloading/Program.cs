using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_15_overloading
{
    class MyClass
    {
        public void MyMethod() 
        {
            Console.WriteLine("This is MyMethod");
        }

        public void MyMethod(string stringParam)
        {
            Console.WriteLine("This is MyMethod with string: {0}", stringParam);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();
            myObject.MyMethod();
            myObject.MyMethod("Custom string");
        }
    }
}
