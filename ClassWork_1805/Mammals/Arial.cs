using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_1805.Mammals
{
   public class Arial : Mammal
    {
        private int weightIncreace;

        public Arial(int age) : base(age)
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
