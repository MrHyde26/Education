using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_1805.Calculator
{
    public class MultiplicationOperation: Operation
    {
        public override void OperationCalc(double operand1, double operand2)
        {
            Console.WriteLine($"Sum = {operand1+  operand2}");
        }
    }
}
