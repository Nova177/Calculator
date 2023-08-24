using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Represents a calculator system that uses input and logic components to perform calculations and display results.
    /// </summary>
    public class Calculator
    {
        private IConsoleOutputInput inputOutput;
        private ICalculationLogic logic;


        public Calculator(IConsoleOutputInput inputOutput, ICalculationLogic logic)
        {
            this.inputOutput = inputOutput;
            this.logic = logic;
        }

        /// <summary>
        /// Starts the calculator system, displaying a welcome message and performing a calculation.
        /// </summary>
        public void CalculatorSystem()
        {
            inputOutput.Welcome();

            inputOutput.ResultOutput(logic.Calculation(inputOutput));
        }
    }
}
