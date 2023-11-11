using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            /* (11/11/23, 1) Commenting-out the thrown `NotImplementedException()` and making the `Calculator` class's 
            `Multiply()` method functional: */
            // throw new NotImplementedException();
            return first * second;
        }

        public double Divide(double first, double second)
        {
            return first / second;
        }
        
        /* (11/11/23, 3) Attempting refactoring of project by taking input solicitation funcationality out of "Program" class 
        and repackaging it as `Calculator.GetInput()` method: */
        public List<string> GetInput()
        {
            List<string> inputList = new List<string>();

            string userInputOne = Console.ReadLine();
            inputList.Add(userInputOne);
            string userInputTwo = Console.ReadLine();
            inputList.Add(userInputTwo);
            
            return inputList;
        }
    }
}