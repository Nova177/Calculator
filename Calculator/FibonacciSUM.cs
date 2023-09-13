using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator 
{
    /// <summary>
    /// Represents a class for calculating the sum of Fibonacci numbers up to a specified limit.
    /// </summary>
    public class FibonacciSUM : ICalculationLogic
    {
        /// <summary>
        /// Calculates the sum of Fibonacci numbers up to the specified limit using the provided input/output interface.
        /// </summary>
        /// <param name="io">The input/output interface used for user interaction.</param>
        public void Calculation(IInputOutput io)
        {

            int number = Convert.ToInt32(io.Input(""));
            int fn1 = 0;
            int fn2 = 1;
            int sum = fn1 + fn2;
            for (int i = 2; i <= number; i++)
            {
                int nextFibonacci = fn1 + fn2;
                sum += nextFibonacci;

                fn1 = fn2;
                fn2 = nextFibonacci;
            }
            io.ResultOutput($"The sum of each Fibonacci is: {sum}",sum);
            
        }
    }
}
