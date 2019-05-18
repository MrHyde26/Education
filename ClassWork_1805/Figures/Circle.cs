using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_1805.Figures
{
    public class Circle : Figure
    {
        public int radius;

        public Circle(int coordinatesX, int coordinatesY, int radius)
            : base(coordinatesX, coordinatesY)
        {
            this.radius = radius;
        }

        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    Console.WriteLine("Radius cant <=0");
                }
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"We draw circle with center coordinates x={this.coordinatesX} and y={this.coordinatesX} and radius {this.radius}");
        }
    }
}
