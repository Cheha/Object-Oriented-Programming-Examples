using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2_Structure_vs_Class
{
    class Program
    {
        struct Point_struct
        {
            public int x;
            public int y;

            public Point_struct(int x_struct, int y_struct)
            {
                x = x_struct;
                y = y_struct;
            }

            public void Inc_struct()
            {
                x++;
                y++;
            }

            public void Decr_struct()
            {
                x--;
                y--;
            }

            public void Display_Struct()
            {
                Console.WriteLine("Struct point x = {0}, y = {1}", x, y);
            }
        }

        struct Point_class
        {
            public int x;
            public int y;

            public Point_class(int x_class, int y_class)
            {
                x = x_class;
                y = y_class;
            }

            public void Inc_class()
            {
                x++;
                y++;
            }

            public void Decr_class()
            {
                x--;
                y--;
            }

            public void Display_class()
            {
                Console.WriteLine("Class point x = {0}, y = {1}", x, y);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
