using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1105.Figure
{
    public class Rhombus : Figures
    {
        private int sideA;

        private int sideB;

        public Rhombus(int coordinatesX, int coordinatesY, int sideA, int sideB)
           : base(coordinatesX, coordinatesY)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public int SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                if (value > 0)
                {
                    sideA = value;
                }
                else
                {
                    Console.WriteLine("Side cant <=0");
                }
            }
        }

        public int SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                if (value > 0)
                {
                    sideB = value;
                }
                else
                {
                    Console.WriteLine("Side cant <=0");
                }
            }
        }
    }
}
