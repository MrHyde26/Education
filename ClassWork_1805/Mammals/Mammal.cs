using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_1805.Mammals
{
    public class Mammal
    {
        public virtual int WeightIncreace { get; set; }
        private int age;
        private int weight = 10;

    public Mammal(int age)
        {
            Age = age;
        }

        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                age = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            protected set
            {
                weight = value;
            }

        }

        public virtual void Eat(int foodAmount)
        {

            if (foodAmount > 5)
            {
                this.weight += this.WeightIncreace;
            }
            if (age < 1)
            {
                Console.WriteLine($"Animal eat milk and him weight {this.weight}");
            }
            else
            {
                Console.WriteLine($"Animal eat other eat and him weight {this.weight}");
            }
        }
    }
}
