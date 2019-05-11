using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1105.Plants
{
    public class Plant
    {
        public string view { get; set; }

        public Colour colour { get; set; }

        public int height;

        public Plant(string view, Colour colour, int height)
        {
            this.view = view;
            this.colour = colour;
            this.height = height;
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Height cant <=0");
                }
            }
        }

        public void State(int minerals, int water = 0)
        {
            if (water < 0 || minerals < 0)
            {
                Console.WriteLine("Error");
            }
            else if (water == 0)
            {
                Colored();
            }
            else if (minerals == 0)
            {
                Grow(water);
            }
            else
            {
                Oxygened(minerals, water);
            }

        }

        public void Grow(int water)
        {
            Console.WriteLine($"{view} was watered {water} liter");
            Console.WriteLine($"{view} was grawed {water} sm");
        }

        public void Colored()
        {
            colour++;
        }

        public void Oxygened(int minerals, int water)
        {
            Grow(water);
            colour++;
            Console.WriteLine($"{view} was saw {minerals*water} oxygen");
        }
    }
}
