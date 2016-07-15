using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_5_Arrays_as_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var int_array = new int[] { 1, 2, 4 };
            var str_array = new string[] { "Hello", "Array", null };
            var nullable_array = new[] { 0, (int?)1, 2};

            Console.WriteLine(int_array.GetType());
            Console.WriteLine(str_array.GetType());
            Console.WriteLine(nullable_array.GetType());
            Console.WriteLine(nullable_array.GetLength(0));
        }
    }
}
