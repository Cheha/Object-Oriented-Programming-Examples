using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_22_Sealed_class
{
    sealed class SealedClass
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }


    class InheritedClass : SealedClass
    {
        public int Multiplication(int x, int y)
        {
            return x * y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SealedClass sealedCls = new SealedClass();
            int total = sealedCls.Add(4, 5);
            Console.WriteLine("Total = " + total.ToString());
        }
    }
}
