using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_14_named_and_optional_params
{
    class MyClass
    {
        public void NameArgsMethod(int param1, string param2)
        {
            Console.WriteLine("param1: {0}, param2: {1}", param1, param2); 
        }

        public void NameArgsMethod(int param1, int param2)
        {
            Console.WriteLine("param1: {0}, param2: {1}", param1, param2);
        }

        public void OptionalArgsMethod(int param1, string param3 = "asdasd", string param2 = "Some string")
        {
            Console.WriteLine("param1: {0}, param2: {1}", param1, param2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();
            myObject.NameArgsMethod(param2: "Named string", param1: 5);
            myObject.NameArgsMethod
           // myObject.OptionalArgsMethod(8, param2: "asdads");
            Console.ReadLine();
        }
    }
}
