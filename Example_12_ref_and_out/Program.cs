using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_12_ref_and_out
{
    class MyClass
    {
        public void MyMethod(ref int x, out int y)
        { 
            // assigning of param1 is not necessary
            // butt param2 is necessary
            // param1 = 10;
            //param2 = 100;
            x = 7;
            y = 100;
           // Console.WriteLine("param1: {0}", x);
            //Console.WriteLine("param2: {0}", y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();
            int x = 4, y;
            myObject.MyMethod(ref x, out y);
            Console.WriteLine("x: {0}", x);
            Console.WriteLine("y: {0}", y);
            Console.ReadLine();
        }
    }
}
