using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_1805.Humans
{
    public class Russian : Human
    {
        public Russian(string name)
            : base(name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine($"Привет {this.Name} !");
        }
    }
}
