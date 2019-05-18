using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1405
{
    class Program
    {
        static void Main(string[] args)
        {
            var singletone = Singleton.GetInstance();
            
        }
    }

    class Singleton
    {
        private static Singleton instance;

        public int someField;

        private Singleton()
            {

            }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        public void DoSomeSheet()
        {

        }
    }
}
