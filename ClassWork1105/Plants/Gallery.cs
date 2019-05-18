using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1105.Plants
{
   public class Gallery
    {
        public Worker worker { get; set; }
        public Gallery(Worker worker)
        {
            this.worker = worker;
        }

        public void Produce(int minerals, int water)
        {
            Plant[] plants =
            {
        new Flowers(10, "romashka", Colour.Brown, 10),
        new Flowers(5, "begonya", Colour.Brown, 12),
        new Trees(5, "bereza", Colour.Brown, 120),
        new Trees(5, "dub", Colour.Brown, 340)
            };

            foreach (var item in plants)
            {
                if (item is Flowers flower)
                { 
                    worker.Watering(flower, minerals, water);
                }
                else if (item is Trees tree)
                {
                    worker.Watering(tree, minerals, water);
                }
            }
        }
   }
}
