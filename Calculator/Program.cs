using System;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IConsoleOutputInput outputInput = new ConsoleInputOutput();
            ICalculationLogic logic = new StatisticalQuantitiesCalculation();
            Calculator calculator = new Calculator(outputInput, logic);
            //wpf logic ggf in der Program klasse handeln. Operationen entgegen nehmen bevor.
            //erstelle input output cal class abfrage was will man eingeben (menü) berechnen, ich möchte sumFib berechnen, dann soll das program das aufrufen (instaziere fibSum object)


            calculator.CalculatorRun(); // Code soll methoden haben die selbsterklärend sind.
            //Code soll man lesen wie Zeitung
        }
    }
}