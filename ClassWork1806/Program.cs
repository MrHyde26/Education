using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1806
{
    class Program
    {
        static void Main(string[] args)
        {
            IReadOnlyCollection<int> collection = new ReadOnlyCollection<int>(new Collection<int> {1,2,3,4});
        }
    }
}
