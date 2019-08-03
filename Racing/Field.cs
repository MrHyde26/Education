using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class Field
    {
        private int startX;
        private int startY;
        public int Width { get; } = 10;
        public int Height { get; } = 20;

        private List<Figure> figures;

        private void Initialize()
        {
            //new OtherCar();
        }

        private bool IsPositionFree(Figure figures)
        {
            return true;
        }
    }
}
