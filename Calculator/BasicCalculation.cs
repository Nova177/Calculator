namespace Calculator
{
    public class BasicCalculation : ICalculationLogic
    {
        /// <summary>
        /// Calculates two numbers with the basic Math operators
        /// </summary>
        /// <param name="io"></param>
        /// <returns></returns>
        public double Calculation(IConsoleOutputInput io)
        {
            

            double number1 = io.Input();
            double number2 = io.Input();
            char calculationTypes = io.GetOperator();
            double result;

            switch (calculationTypes)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result =  number1 * number2;
                    break;
                case '/':
                    if(number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        return 0;
                        throw new Exception("Division by zero is not allowed.");
                        
                    }
                    break;
                default:
                    throw new Exception("Invalid Operator");
                    
            }
            return result;
        }




    }
}
