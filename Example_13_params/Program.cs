using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_13_params
{
    class MyClass
    {
        public void MyMethod(params int[] parameters)
        {
            Console.WriteLine("parameters length: {0}", parameters.Length);
        }

        public void MyMethod2(string color, params int[] parameters, params int[] parameters2) { 
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 6, 7, 4, 3};
            MyClass myObject = new MyClass();
            myObject.MyMethod(3, 5, 6);
            myObject.MyMethod2("string", 3, 6);
            myObject.MyMethod(array);
        }
    }
}
