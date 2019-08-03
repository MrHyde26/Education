using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class Node
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public void Up()
        {
            this.y=this.y + 1;
        }

        public void Down()
        {
            this.y = this.y - 1;
        }

        public void Left()
        {
            this.x = this.x + 1;
        }

        public void Right()
        {
            this.x = this.x - 1;
        }
    }
}
