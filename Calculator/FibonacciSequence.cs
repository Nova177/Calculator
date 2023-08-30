namespace Calculator
{
    
    public class FibonacciSequence : ICalculationLogic
    {
        
        //überarbeiten weil du willst ggf doch eine Liste eingeben
        public void Calculation(IConsoleOutputInput io)
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
