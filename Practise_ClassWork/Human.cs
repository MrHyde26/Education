using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_ClassWork
{
    public class Human
    {
       private readonly Fridge fridge;

        public Human(Fridge fridge)
        {
           this.fridge = new Fridge();

           this.fridge.EventFridge += CurrentFridgeInvoced;

           this.fridge.Main();
        }

        public void CurrentFridgeInvoced(FridgeEvent e)
        {
            fridge.CurrentState();
        }
    }
}
