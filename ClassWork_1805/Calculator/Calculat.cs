using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_1805.Calculator
{
    public class Calculat
    {
        public SumOperation Sum;
        public DivideOperation Divide;
        public MultiplicationOperation Multiplication;
        public SubtractionOperation Subtraction;

        public Calculat()
        {
            this.Sum = new SumOperation();
        }

        public void Calculation(double operand1, double operand2)
        {
            Sum.OperationCalc(operand1, operand2);
            Divide.OperationCalc(operand1, operand2);
            Multiplication.OperationCalc(operand1, operand2);
            Subtraction.OperationCalc(operand1, operand2);
        }
    }
}
