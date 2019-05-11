using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1105.Figure
{
    public class Triangle : Figures
    {
        public int sideA;

        public int sideB;

        public int sideC;

        public Triangle(int coordinatesX, int coordinatesY, int sideA, int sideB, int sideC)
           : base(coordinatesX, coordinatesY)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
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

        public int SideC
        {
            get
            {
                return sideC;
            }
            set
            {
                if (value > 0)
                {
                    sideC = value;
                }
                else
                {
                    Console.WriteLine("Side cant <=0");
                }
            }
        }

        public void Draw()
        {
            int perim = this.sideA + this.sideB + this.sideC;
            Console.WriteLine($"We draw triangle with center coordinates x={this.coordinatesX} and y={this.coordinatesX} and perimetr {perim}");
        }
    }
}

