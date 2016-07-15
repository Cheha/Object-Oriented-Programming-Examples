using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_9_Interface
{
    public interface IMessage
    {
        void ShowMessage();
        int GetCount();
    }

    public class StudentMessage : IMessage
    {

        public void ShowMessage()
        {
            Console.WriteLine("Message from Student");
        }

        public int GetCount()
        {
            return 4;
        }
    }

    public class TeacherMessage : IMessage
    {

        public void ShowMessage()
        {
            Console.WriteLine("Message from Teacher");
        }

        public int GetCount()
        {
            return 12;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var studMessage = new StudentMessage();
            Console.WriteLine("Student method usage:");
            for (int i = 0; i < studMessage.GetCount(); i++)
            {
                studMessage.ShowMessage();
            }

        }
    }
}
