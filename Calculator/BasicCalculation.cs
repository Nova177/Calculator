namespace Calculator
{
    /// <summary>
    /// Represents a class for performing basic mathematical calculations on two numbers.
    /// </summary>
    public class BasicCalculation : ICalculationLogic
    {
        /// <summary>
        /// Calculates two numbers with the basic Math operators
        /// </summary>
        /// <param name="io"></param>
        /// <returns></returns>
        public void Calculation(IInputOutput io)
        {
            

            double number1 = io.Input("Nummer 1");
            double number2 = io.Input("Nummer 2");
            char calculationTypes = io.GetOperator();
            double result;

            switch (calculationTypes)
            {
                case '+':
                    result = number1 + number2;
                    io.ResultOutput("Result: {0}", result);
                    break;
                case '-':
                    result = number1 - number2;
                    io.ResultOutput("Result:{0}", result);
                    break;
                case '*':
                    result =  number1 * number2;
                    io.ResultOutput("Result:{0}", result);
                    break;
                case '/':
                    if(number2 != 0)
                    {
                        result = number1 / number2;
                        io.ResultOutput("Result:{0}", result);
                    }
                    else
                    {
                      
                        throw new Exception("Division by zero is not allowed.");
                        
                    }
                    break;
                default:
                    throw new Exception("Invalid Operator");
                    
            }
            
        }




    }
}
