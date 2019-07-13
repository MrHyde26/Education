using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1307.Task1._2
{
    public class EventPingPong:EventArgs
    {
        private DateTime timeEvent;

        public EventPingPong(DateTime timeEvent)
        {
            this.timeEvent = timeEvent;
        }
            
    }
}
