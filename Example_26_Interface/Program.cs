using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_26_Interface
{
    public interface IBird
    {
        //string Genus { get; }
        void Voice();
    }

    public interface IHorse
    {
        void Voice();
    }

    public class Bird : IBird, IHorse
    {
        public Bird()
        {
            //Genus = "bird";
        }

        public void IBird.Voice()
        {
            Console.WriteLine("I'm bird");
        }

        //public void IHorse.Voice()
        //{
        //    Console.WriteLine("I'm horse");
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            IBird horse = new Bird();
            
        }
    }
}
