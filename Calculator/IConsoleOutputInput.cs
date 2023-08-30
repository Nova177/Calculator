
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     public interface IConsoleOutputInput
     {
       
        void Welcome();
        void Instructions();
        
        double Input(string input); 

        char GetOperator();
        void ResultOutput(string output, double result); 
         
     }
}
