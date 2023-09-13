namespace Calculator
{

    /// <summary>
    /// Represents a class for calculating Fibonacci sequence values.
    /// </summary>
    public class FibonacciSequence : ICalculationLogic
    {

        /// <summary>
        /// Calculates Fibonacci sequence values up to the specified limit and displays the results.
        /// </summary>
        /// <param name="io">An instance of the input/output interface for user interaction.</param>
        public void Calculation(IInputOutput io)
        {


            double fn = io.Input("");
            



            double fn1 = 0;
            double fn2 = 1;
            double nextFibonacci = 0;

            io.ResultOutput("fib(0): {0}", fn1);
            io.ResultOutput("fib(1): {0}", fn2);
            for (int i = 2; i <= fn; i++)
            {
                nextFibonacci = fn1 + fn2;
                



                fn1 = fn2;
                fn2 = nextFibonacci;
                io.ResultOutput($"fib({i}): {nextFibonacci}", nextFibonacci);
                
            }
            
        }
        

    }
}
