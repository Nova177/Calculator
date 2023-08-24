using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     public interface IConsoleOutputInput
    {
       
        void Welcome();
        double Input();

        char GetOperator();
        void ResultOutput(double result);

    }
}
