using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work25_05.Switchable
{
    public class Fan: ISwitchable
    {
        public bool state { get; set; }

        public void On()
        {
            state = true;
            Console.WriteLine("Fan is on");
            ToString();
        }

        public void Off()
        {
            state = false;
            Console.WriteLine("Fan is Off");
        }

        public override string ToString()
        {
            if (state)
            {
                return "Fan shine";
            }
            else
            {
                return "Fan not shine";
            }
        }
    }
}
