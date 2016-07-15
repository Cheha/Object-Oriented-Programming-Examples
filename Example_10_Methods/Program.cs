using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_10_Methods
{
    class CustomClass 
    {
        
        public void MethodWithoutParams() 
        {
            Console.WriteLine("MethodWithoutParams is called");    
        }

        public void MethodWithParams(int[] array)
        {
            array = new int[] { 10, 40, 55, 43 };
            Console.WriteLine("MethodWithParams is called");
          //  Console.WriteLine("array[0] = {0}", array[0]);
        }

        public void MethodForInt(int x) {
            Console.WriteLine("x {0}", x);
            x = 200;
            Console.WriteLine("x {0}", x);
        }

        public int Sum(int[] array, int size)
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            CustomClass myClass = new CustomClass();
            myClass.MethodWithParams(array);
            Console.WriteLine(array[0]);
            Console.ReadLine();
        }
    }
}
