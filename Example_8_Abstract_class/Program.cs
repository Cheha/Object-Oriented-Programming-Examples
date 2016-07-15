using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_8_Abstract_class
{
    abstract class UserInfo
    {
        protected string usr_name;
        protected byte usr_number;

        public UserInfo(string userName, byte userNumber)
        {
            usr_name = userName;
            usr_number = userNumber;
        }

        public abstract string User_Info(); // abstract method
    }

    class UserGroup : UserInfo
    {
        string group;

        public UserGroup(string userGroup, string userName, byte userNumber) 
            : base (userName, userNumber)
        {
            group = userGroup;
        }

        public override string User_Info()
        {
            return group + " " + usr_name + " " + usr_number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var userGroup = new UserGroup("Albert", "Moon", 1);
            Console.WriteLine(userGroup.User_Info());
        }
    }
}
