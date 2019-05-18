using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_1805.Figures
{
    public class Square : Figure
    {
        private int sideA;

        private int sideB;

        public Square(int coordinatesX, int coordinatesY, int sideA, int sideB)
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

        public override void Draw()
        {
            int square = this.sideA * this.sideB;
            Console.WriteLine($"We draw square with center coordinates x={this.coordinatesX} and y={this.coordinatesX} and square {square}");
        }
    }
}
