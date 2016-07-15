using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_19_Composition
{
    public class Jet
    {
        public double power;
    }

    public class JetLiner
    {
        public Jet[] jets = new Jet[4];
    }

    class Program
    {
        static void Main(string[] args)
        {
            JetLiner jetLiner = new JetLiner();
            // initialization of jet's power for jetliner
            for (int i = 0; i < jetLiner.jets.Length; i++) 
            {
                jetLiner.jets[i] = new Jet();
                jetLiner.jets[i].power = 100; 
            }

            Jet jet = new Jet();
            jet.power = 50;
            jetLiner.jets[0] = jet;

            for (int i = 0; i < jetLiner.jets.Length; i++)
            {
                Console.WriteLine("Power of jets[{0}]: {1}", i, jetLiner.jets[i].power);
            }
        }
    }
}
