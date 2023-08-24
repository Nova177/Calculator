using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator 
{
    public class FibonacciSUM : ICalculationLogic
    {
        public double Calculation(IConsoleOutputInput io)
        {

            int number = Convert.ToInt32(io.Input());
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
            return sum;
        }
    }
}
