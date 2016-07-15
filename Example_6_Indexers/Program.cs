using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_6_Indexers
{
    class IndexedStudents 
    {
        static public int stud_cnt = 8;
        private string[] stud_list = new string[stud_cnt];

        public IndexedStudents()
        {
            for (int j = 0; j < stud_cnt; j++) {
                stud_list[j] = "C# student";
            }
        }

        public string this[int index_var]
        {
            get {
                string temp;
                if (index_var >= 0 && index_var < stud_cnt - 1)
                {
                    temp = stud_list[index_var];
                }
                else
                {
                    temp = "";
                }
                return temp;
            }
            set {
                if (index_var >= 0 && index_var < stud_cnt - 1)
                {
                    stud_list[index_var] = value;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IndexedStudents students = new IndexedStudents();
            students[0] = "C++ student";
            students[1] = "JavaScript student";
            students[2] = "Assembler student";
            for (int i = 0; i < IndexedStudents.stud_cnt; i++)
            {
                Console.WriteLine("students[{0}] equals to {1}", i, students[i]);
            }
            Console.ReadLine();
        }
    }
}
