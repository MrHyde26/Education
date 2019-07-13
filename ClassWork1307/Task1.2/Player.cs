using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1307.Task1._2
{
    public delegate void PingPongDelegate(EventPingPong e);

    public class Player1
    {
        public Pong1 pong;
        public Ping1 ping;

        public Player1(Pong1 pong, Ping1 ping)
        {
            this.ping = new Ping1();
            this.pong = new Pong1();

            this.ping.EventPing += OnPingInvoked;
            this.pong.EventPong += OnPongInvoked;

            this.ping.DoPing();
        }
        public void OnPingInvoked(EventPingPong e)
        {
            Console.WriteLine(e);
            pong.DoPong();
            
        }

        public void OnPongInvoked(EventPingPong e)
        {
            Console.WriteLine(e);
            ping.DoPing();
            
        }

    }
}
