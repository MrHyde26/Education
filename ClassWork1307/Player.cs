using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1307
{
   

    public class Player
    {
        public Pong pong;
        public Ping ping;

        public Player(Pong pong, Ping ping)
        { 
        this.ping = new Ping();
        this.pong = new Pong();

        this.ping.EventPing +=OnPingInvoked;
            this.pong.EventPong +=OnPongInvoked;

            this.ping.DoPing();
        }

        public void OnPingInvoked(object sender, EventArgs e)
        {
            pong.DoPong();
        }

        public void OnPongInvoked(object sender, EventArgs e)
        {
            ping.DoPing();
        }
    }

   
}
