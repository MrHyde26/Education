using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work25_05.Switchable
{
    public class Lamp: ISwitchable
    {
        public bool state { get; set; }

        public void On()
        {
            state = true;
            Console.WriteLine("Lamp is on");         
        }

        public void Off()
        {
            state = false;
            Console.WriteLine("Lamp is Off");
        }

        public override string ToString()
        {
            if (state)
            {
                return "Lamp shine";
            }
            else
            {
                return "Lamp not shine";
            }
        }
    }
}
