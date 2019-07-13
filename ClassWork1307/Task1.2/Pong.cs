using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1307.Task1._2
{
    public class Pong1
    {
       
        public event PingPongDelegate EventPong;

        protected virtual void OnPong(EventPingPong e)
        {

            this.EventPong?.Invoke(e);
        }

        public void DoPong()
        {
            Console.WriteLine("Pong");
            System.Threading.Thread.Sleep(1000);
            this.OnPong(new EventPingPong(DateTime.Now));
        }
    }
}
