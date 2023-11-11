using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the C# In-Console Calculator! Input, as an integer, '1' to add, '2' to subtract, '3' to multiply, or '4' to divide two numbers.");
            Console.WriteLine("Enter 'Quit' to terminate the program.");

            var calculator = new Calculator();
            var input = Console.ReadLine();

            /* (11/11/23, 9) So that users do not have to re-run the program after every single operation, integrating `while`-loop to continually check user input. If user 
            inputs some derivative of string "quit", program terminates: */
            while(input.ToLower() != "quit")
            {
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter two integers to add:");
                        /* (11/11/23, 4) Commenting-out explicit solicitation of user input on two lines immediately below this comment and replacing with invocation of 
                        `Calculator` class's `GetInput()` method (note how output from `calculator.GetInput()` is stored in `additionInputs` List of strings): */
                        // var addNumber1 = Console.ReadLine();
                        // var addNumber2 = Console.ReadLine();
                        List<string> additionInputs = calculator.GetInput();

                        /* (11/11/23, 5) Note indexing of `additionInputs` List to obtain user-inputted numbers: */
                        if (int.TryParse(additionInputs[0], out int addNumOne) && int.TryParse(additionInputs[1], out int addNumTwo))
                        {
                            Console.Write($"{additionInputs[0]} + {additionInputs[1]} = ");
                            Console.WriteLine(calculator.Add(addNumOne, addNumTwo));
                        }
                        else
                        {
                            Console.WriteLine("One or more of the inputted numbers are not integers. Please follow input instructions.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter two integers to subtract:");
                        /* (11/11/23, 6) Commenting-out explicit solicitation of user input on two lines immediately below this comment and replacing with invocation of 
                        `Calculator` class's `GetInput()` method (note how output from `calculator.GetInput()` is stored in `subtractionInputs` List of strings): */
                        // var subtractNumber1 = Console.ReadLine();
                        // var subtractNumber2 = Console.ReadLine();
                        List<string> subtractionInputs = calculator.GetInput();

                        if (int.TryParse(subtractionInputs[0], out int subNumOne) && int.TryParse(subtractionInputs[1], out int subNumTwo))
                        {
                            Console.Write($"{subtractionInputs[0]} - {subtractionInputs[1]} = ");
                            Console.WriteLine(calculator.Subtract(subNumOne, subNumTwo));
                        }
                        else
                        {
                            Console.WriteLine("One or more of the inputted numbers are not integers. Please follow input instructions.");
                        }
                        break;

                    case "3":
                        /* (11/11/23, 2) Adding code to make multiplication functionality for "C# In-Console Calculator" operational: */
                        Console.WriteLine("Enter two integers to multiply:");
                        /* (11/11/23, 7) Commenting-out explicit solicitation of user input on two lines immediately below this comment and replacing with invocation of 
                        `Calculator` class's `GetInput()` method (note how output from `calculator.GetInput()` is stored in `multiplicationInputs` List of strings): */
                        // var multiplyNumber1 = Console.ReadLine();
                        // var multiplyNumber2 = Console.ReadLine();

                        List<string> multiplicationInputs = calculator.GetInput();

                        if (int.TryParse(multiplicationInputs[0], out int multNumOne) && int.TryParse(multiplicationInputs[1], out int multNumTwo))
                        {
                            Console.Write($"{multiplicationInputs[0]} * {multiplicationInputs[1]} = ");
                            Console.WriteLine(calculator.Multiply(multNumOne, multNumTwo));
                        }
                        else
                        {
                            Console.WriteLine("One or more of the inputted numbers are not integers. Please follow input instructions.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Enter two integers to divide:");
                        /* (11/11/23, 8) Commenting-out explicit solicitation of user input on two lines immediately below this comment and replacing with invocation of 
                        `Calculator` class's `GetInput()` method (note how output from `calculator.GetInput()` is stored in `divisionInputs` List of strings): */
                        // var divideNumber1 = Console.ReadLine();
                        // var divideNumber2 = Console.ReadLine();

                        List<string> divisionInputs = calculator.GetInput();

                        if (double.TryParse(divisionInputs[0], out double divNumOne) && double.TryParse(divisionInputs[1], out double divNumTwo))
                        {
                            Console.Write($"{divisionInputs[0]} / {divisionInputs[1]} = ");
                            Console.WriteLine(calculator.Divide(divNumOne, divNumTwo));
                        }
                        else
                        {
                            Console.WriteLine("One or more of the inputted numbers are not integers. Please follow input instructions.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid input. Please follow input instructions.");
                        break;
                }
                Console.WriteLine();
                /* (11/11/23, 10) Soliciting new user input after each iteration of `while`-loop: */
                Console.WriteLine("Input, as an integer, '1' to add, '2' to subtract, '3' to multiply, or '4' to divide two numbers.");
                Console.WriteLine("Enter 'Quit' to terminate the program.");
                input = Console.ReadLine();
            }
            /* (11/11/23, 11) If user inputs some derivative of string "quit", program terminates: */
            Console.WriteLine("Thank you for using the C# In-Console Calculator! Have a nice day.");
        }
    }
}