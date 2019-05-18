using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_1805.Humans
{
    public abstract class Human
    {
        public string Name { get; set; }

        public Human(string name)
        {
            this.Name = name;
        }

        public abstract void SayHello();
        
    }
}
