using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1105.Plants
{
    public class Worker
    {
        public void Watering(Plant plants,int minerals,int water)
        {
            plants.State(minerals, water);
        }
    }
}
