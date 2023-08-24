using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// rovides input and output using the console.
    /// </summary>
    public class ConsoleInputOutput : IConsoleOutputInput
    {

        /// <summary>
        /// Displays a welcome message.
        /// </summary>
        public void Welcome()
        {
            Console.WriteLine("----Calculator----!");
        }

        /// <summary>
        /// Takes user input and converts it to a double.
        /// </summary>
        /// <returns>The user input as a double. Returns 0 if input is invalid.</returns>
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

        /// <summary>
        /// Takes user input for an operator.
        /// </summary>
        /// <returns>The operator entered by the user.</returns>
        public char GetOperator()
        {
            Console.Write("Enter an operator (+, -, *, /): ");
            char mathOperator = Convert.ToChar(Console.ReadLine());
            return mathOperator;
        }

        /// <summary>
        /// Displays the result to the user.
        /// </summary>
        /// <param name="result">The result to be displayed</param>
       public void ResultOutput(double result)
        {
            Console.WriteLine("Das Ergebnis ist : {0}", result);
            Console.ReadKey();
        }
    }
}

 
