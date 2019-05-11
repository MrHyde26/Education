using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1105.Plants
{
    public class Trees : Plant
    {
        public int branches;

        public Trees(int branches, string view, Colour colour, int height)
            : base(view, colour, height)
        {
            this.branches = branches;
        }

        public int Branches
        {
            get
            {
                return branches;
            }
            set
            {
                if (value > 0)
                {
                    branches = value;
                }
                else
                {
                    Console.WriteLine("Branches cant <=0");
                }
            }
        }

        public void Breakaway()
        {
            Console.WriteLine($"After wind left{branches - 1}");
        }
    }
}
