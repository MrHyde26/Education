using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_1805.Mammals
{
    public class Subterranean : Mammal
    {
        private int weightIncreace;

        public Subterranean(int age) : base(age)
        {

        }

        public override int WeightIncreace
        {
            get
            {
                return 2;
            }
        }
    }
}
