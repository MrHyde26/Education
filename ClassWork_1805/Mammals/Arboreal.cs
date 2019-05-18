using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_1805.Mammals
{
    public class Arboreal : Mammal
    {
        private int weightIncreace;

        public Arboreal(int age) : base(age)
        {

        }

        public override int WeightIncreace
        {
            get
            {
                return 5;
            }
        }
    }
}
