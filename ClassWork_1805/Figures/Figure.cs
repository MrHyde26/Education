using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_1805.Figures
{
    public class Figure
    {
        public int coordinatesX { get; set; }

        public int coordinatesY { get; set; }

        public Figure(int coordinatesX, int coordinatesY)
        {
            this.coordinatesX = coordinatesX;
            this.coordinatesY = coordinatesY;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"We draw figure with center coordinates x={this.coordinatesX} and y={this.coordinatesX}");
        }
    }
}
