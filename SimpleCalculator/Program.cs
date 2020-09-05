using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string startOver = "y";
            Console.WriteLine("   _____  _____  _____          _      _____ ");
            Console.WriteLine("  / ____|/ ____|/ ____|   /\\   | |    / ____|");
            Console.WriteLine(" | |    | (___ | |       /  \\  | |   | |     ");
            Console.WriteLine(" | |     \\___ \\| |      / /\\ \\ | |   | |");
            Console.WriteLine(" | |____ ____) | |____ / ____ \\| |___| |____ ");
            Console.WriteLine("  \\_____|_____/ \\_____/_/    \\_\\______\\_____|");
            Console.WriteLine("CSCALC: A basic implementation of a calculator in C#");
            Console.WriteLine("Programmed by Manh-Anh Tuan Nguyen & Olivier Lemire, (c) 2020.");
            while(startOver.Equals("y"))
            {
                bool error = true;
                while (error)
                {
                    try
                    {
                        //Class to convert user input
                        InputConverter inputConverter = new InputConverter();

                        //Class to perform actual calculations
                        CalculatorEngine calculatorEngine = new CalculatorEngine();
                        Console.WriteLine("Please enter a number:");
                        double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                        Console.WriteLine("Great! Now enter another number:");
                        double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                        Console.WriteLine("What should I do with the 2 values?");
                        string operation = Console.ReadLine();

                        double result = calculatorEngine.Calculate(operation.ToLower(), firstNumber, secondNumber);


                        //Console.WriteLine("{0} result");
                        error = false;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        error = true;
                    }

                }
                Console.WriteLine("Again?(Press y to start over)");
                startOver = Console.ReadLine();
            }

        }
    }
}
