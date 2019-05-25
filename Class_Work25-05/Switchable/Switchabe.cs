using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work25_05.Switchable
{
    public class Switchabe
    {
        public void Execute()
        {
            Console.WriteLine("Enter 1 to on Fan and Lamp or 2 to off");
            int state = Convert.ToInt32(Console.ReadLine());

            Fan fan = new Fan();
            Lamp lamp = new Lamp();

            if (state == 1)
            {
                fan.On();
                Console.WriteLine(fan);
                lamp.On();
                Console.WriteLine(lamp);
            }
            else
            {
                fan.Off();
                Console.WriteLine(fan);
                lamp.Off();
                Console.WriteLine(lamp);
            }
        }
    }
}
