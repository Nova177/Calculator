namespace Calculator
{
    public class FibonacciSequence : ICalculationLogic
    {
        

        public double Calculation(IConsoleOutputInput io)
        {


            double fn = io.Input();
            



            double fn1 = 0;
            double fn2 = 1;
            double nextFibonacci = 0;

            for (int i = 2; i <= fn - 1; i++)
            {
                nextFibonacci = fn1 + fn2;
                



                fn1 = fn2;
                fn2 = nextFibonacci;
                io.ResultOutput(nextFibonacci);
                
            }
            return nextFibonacci + fn1;
        }
        

    }
}
