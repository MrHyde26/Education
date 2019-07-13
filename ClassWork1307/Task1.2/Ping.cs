﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1307.Task1._2
{
   
    public class Ping1
    {
        
        public event PingPongDelegate EventPing;

        protected virtual void OnPing(EventPingPong e)
        {

            this.EventPing?.Invoke(e);
        }

        public void DoPing()
        {
            Console.WriteLine("Ping" + " " + DateTime.Now);
            System.Threading.Thread.Sleep(1000);
            this.OnPing(new EventPingPong(DateTime.Now));
        }
    }
}
