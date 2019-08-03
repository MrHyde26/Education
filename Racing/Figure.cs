using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public abstract class Figure
    {
        private List<Node> nodes;
        public char Symbol { get; }
        public ConsoleColor Color { get; }

        public List<Node> Nodes
        {
            get { return nodes;}
            set { value = nodes;}
        }

        public void Ctor(char symbol, ConsoleColor color)
        {

        }

        protected abstract void InitializeState();

        public abstract void Move(MoveDirection direction, Func<Figure,bool> isFree);
        
    }
}
