using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1105.Plants
{
    public class Flowers : Plant
    {
        public int petals;

        public Flowers(int petals, string view, Colour colour, int height)
            :base(view,colour,height)
        {
            this.petals = petals;
        }

        public int Petals
        {
            get
            {
                return petals;
            }
            set
            {
                if (value > 0)
                {
                    petals = value;
                }
                else
                {
                    Console.WriteLine("Petals cant <=0");
                }
            }
        }

        public void Breakaway()
        {
            Console.WriteLine($"After wind left{petals-1}");
        }
    }
}
