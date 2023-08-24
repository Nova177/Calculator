using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        private IConsoleOutputInput inputOutput;
        private ICalculationLogic logic;


        public Calculator(IConsoleOutputInput inputOutput, ICalculationLogic logic)
        {
            this.inputOutput = inputOutput;
            this.logic = logic;
        }

        public void CalculatorSystem()
        {
            inputOutput.Welcome();

            inputOutput.ResultOutput(logic.Calculation(inputOutput));
        }
    }
}
