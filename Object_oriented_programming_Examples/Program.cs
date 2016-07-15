using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1_First_Class
{
    class Program
    {
        public string hello_str = "Hello World";

        public void WriteHello() {
            Console.WriteLine(hello_str);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.WriteHello();
        }
    }
}
