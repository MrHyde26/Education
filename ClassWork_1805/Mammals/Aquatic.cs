using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_1805.Mammals
{
    public class Aquatic : Mammal
    {
        public Aquatic(int age) : base(age)
        {

        }

        public override int WeightIncreace
        {
            get
            {
                return 4;
            }
        }
    }
}
