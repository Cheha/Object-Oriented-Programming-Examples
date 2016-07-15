using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_11_Obj_as_reference
{
    class MyClass
    {
        public void MyMethod(ref int[] array)
        {
            array = new int[6] { 100, 200, 300, 400, 500, 600};
            Console.WriteLine("My method is calling");
            Console.WriteLine("array[0] = {0}", array[0]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Size before MyMethod: {0}", array.Length);

            MyClass myClass = new MyClass();
            myClass.MyMethod(ref array);

            Console.WriteLine("Size after MyMethod: {0}", array.Length);
            Console.ReadLine();
        }
    }
}
