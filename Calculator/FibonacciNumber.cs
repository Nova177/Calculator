﻿namespace Calculator
{
    /// <summary>
    /// Represents a class for calculating Fibonacci numbers up to a specified iteration using the Fibonacci sequence.
    /// </summary>
    public class FibonacciNumber : ICalculationLogic
    {
        private int fibonacciIteration;
        private int result;
        private int fn1 = 0;
        private int fn2 = 1;

        /// <summary>
        /// Calculates the Fibonacci number for the given iteration using the provided input/output interface
        /// </summary>
        /// <param name="io">The input/output interface used for user interaction.</param>
        /// <returns>The Fibonacci number for the specified iteration</returns>
        public void Calculation(IInputOutput io)
        {
            try
            {
                int result = 0;
                fibonacciIteration = Convert.ToInt32(io.Input(""));
                for (int i = 0; i <= fibonacciIteration - 1; i++)
                {
                    result = fn1 + fn2;
                    fn2 = fn1;
                    fn1 = result;
                    
                }
                io.ResultOutput($"fib({fibonacciIteration}): {result}", result);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured: " + ex.Message);
            }
            

        }
    }
}
