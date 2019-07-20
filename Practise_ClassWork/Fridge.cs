using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_ClassWork
{
    public delegate void FridgeDelegate(FridgeEvent e);

    public class Fridge
    {
        private States state;

        public event FridgeDelegate EventFridge;

        protected virtual void OnFridgeState(FridgeEvent e)
        {
            this.EventFridge?.Invoke(e);
        }

        public void OpenFridge()
        {
            this.state = States.Opened_fridge;
            Console.WriteLine("Fridge is opened");
            this.OnFridgeState(new FridgeEvent());
        }

        public void OpenFreezer()
        {
            this.state = States.Opened_freezer;
            Console.WriteLine("Freezer door is opened");
            this.OnFridgeState(new FridgeEvent());
        }

        public void FridgeOff()
        {
            this.state = States.Off;
            Console.WriteLine("Fridge is off");
            this.OnFridgeState(new FridgeEvent());
        }

        public void FridgeOn()
        {
            this.state = States.On;
            Console.WriteLine("Fridge is on");
            this.OnFridgeState(new FridgeEvent());
        }

        public void CurrentState()
        {
            Console.WriteLine($"Current {this.state}");
        }

        public void Main()
        {
            bool work = true;
            while (work)
            { 
                Console.WriteLine("Enter Open - to open fridge, enter Freezer - to open freezer, enter On to On Fridge, enter Off to off Fridge or enter Exit to Exit");
                string text = Console.ReadLine();

                switch (text)
                {
                    case "Open":
                        OpenFridge();
                        break;
                    case "Freezer":
                        OpenFreezer();
                        break;
                    case "On":
                        FridgeOn();
                        break;
                    case "Off":
                        FridgeOff();
                        break;
                    case "Exit":
                        work = false;
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
        }
    }
}
