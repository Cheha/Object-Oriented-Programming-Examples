using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_17_Static
{
    class MyClass
    {
        public static int value;
    }

    static class MyStaticClass
    {
        public static int stat_x;

        static MyStaticClass()
        {
            stat_x = 4;
        }

        public static void StartMethod(int par)
        {
            stat_x = 5;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass.value = 6;

            MyStaticClass.StartMethod(77);
        }
    }
}
