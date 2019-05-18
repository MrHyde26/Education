using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_1805.Humans
{
    public class English : Human
    {
        public English(string name)
           : base(name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine($"Hi {this.Name} !");
        }
    }
}
