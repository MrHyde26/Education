using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassWork1105.Figure;

namespace ClassWork1105
{
    class Program
    {
        static void Main(string[] args)
        {
            Figures[] figures = {
                new Circle(1,4,10),
                new Circle(5,2,15),
                new Circle(1,4,10),
                new Square (5,1,12,10),
                new Square (5,3,22,10),
                new Square (6,3,7,10),
                new Triangle(5,2,1,5,2),
                new Triangle(5,1,4,5,2),
                new Triangle(5,21,1,5,2),
                new Triangle(5,2,1,5,2)
            };

            foreach (var item in figures)
            {
                if (item is Circle circle)
                {
                    circle.Draw();
                }
                else if (item is Square square)
                {
                    square.Draw();
                }
                else if (item is Triangle triangle)
                {
                    triangle.Draw();
                }
            }
        }
    }
    
}
