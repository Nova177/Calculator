using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Calculator
{
    
    public class ConsoleInputOutput : IConsoleOutputInput
    {


        public void Welcome()
        {
            Console.WriteLine("----Calculator----!");
        }

        public double Input()
        {
            Console.Write("Enter a number: ");
            string input1 = Console.ReadLine();
            if (double.TryParse(input1, out double number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return 0;
            }
           
        }
        

        public char GetOperator()
        {
            Console.Write("Enter an operator (+, -, *, /): ");
            char mathOperator = Convert.ToChar(Console.ReadLine());
            return mathOperator;
        }

        public double Input2()
        {
            Console.Write("Enter a second number: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Defaulting to 0.");
                return 0;
            }
        }

       public void ResultOutput(double result)
        {
            Console.WriteLine("Das Ergebnis ist : {0}", result);
            Console.ReadKey();
        }
    }
}

 
