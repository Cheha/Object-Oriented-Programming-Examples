using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_7_Properties
{
    public class Slot
    {
        int slot_width;
        public int SlotWidth
        {
            get { return slot_width; }
            set { slot_width = value; }
        }

        public Slot(int width)
        {
            slot_width = width;
        }

        public Slot() { 
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var slot = new Slot();
            Console.WriteLine("slot.SlotWidth property value: {0}", slot.SlotWidth);

            var newSlot = new Slot(5);
            Console.WriteLine("newSlot.SlotWidth property value: {0}", newSlot.SlotWidth);
        }
    }
}
