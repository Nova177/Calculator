using System;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IConsoleOutputInput outputInput = new ConsoleInputOutput();
            ICalculationLogic logic = new FibonacciSequence();
            Calculator calculator = new Calculator(outputInput, logic);

            calculator.CalculatorSystem();
        }
    }
}