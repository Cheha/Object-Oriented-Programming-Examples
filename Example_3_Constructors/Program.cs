using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3_Constructors
{
    class Employee
    {
        public static int EmpCount;
        public string FirstName;
        public string LastName;
        public string rank;

        public Employee(string first, string last, string rank)
        {
            this.FirstName = first;
            this.LastName = last;
            this.rank = rank;
        }

        public Employee()
        {
        }

    }

    class Program
    {

        static void Main(string[] args)
        {


            //Employee emp = new Employee("Valery","Mavrodiy","MMM");
            Employee emp = new Employee();
       
            Console.WriteLine("First name = " + emp.FirstName + " , lastname = " + emp.LastName + ", rank = " + emp.rank);
            Console.ReadLine();
        }
    }
}
