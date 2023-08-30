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


        public Calculator(IConsoleOutputInput inputOutput, ICalculationLogic logic) // logic raus und in die Parameterliste von meiner Calculation Logic packen
        {
            this.inputOutput = inputOutput;
            this.logic = logic;
        }

        /// <summary>
        /// Starts the calculator system, displaying a welcome message and performing a calculation.
        /// </summary>
        public void CalculatorRun()
        {
            inputOutput.Welcome();

            logic.Calculation(inputOutput);
            //alles in die logic.Calculation(inputOutput) 
        }
    }
}
