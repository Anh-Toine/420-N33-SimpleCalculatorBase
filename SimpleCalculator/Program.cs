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

            //Class to convert user input
            InputConverter inputConverter = new InputConverter();

            //Class to perform actual calculations
            CalculatorEngine calculatorEngine = new CalculatorEngine();

            string startOver = "y";
            string operation = "";
            double firstNumber = 0.0;
            double secondNumber = 0.0;
            double result = 0.0;


            Console.WriteLine("   _____  _____  _____          _      _____ ");
            Console.WriteLine("  / ____|/ ____|/ ____|   /\\   | |    / ____|");
            Console.WriteLine(" | |    | (___ | |       /  \\  | |   | |     ");
            Console.WriteLine(" | |     \\___ \\| |      / /\\ \\ | |   | |");
            Console.WriteLine(" | |____ ____) | |____ / ____ \\| |___| |____ ");
            Console.WriteLine("  \\_____|_____/ \\_____/_/    \\_\\______\\_____|");
            Console.WriteLine("CSCALC: A basic implementation of a calculator in C#");
            Console.WriteLine("Made by Manh-Anh Tuan Nguyen & Olivier Lemire, (c) 2020.");
            while (startOver.Equals("y"))
            {
                bool error_num1 = true;
                bool error_num2 = true;
                bool error_opt = true;
                while (error_num1)
                {
                    try
                    {

                        Console.WriteLine("Please enter a number(must be a double):");
                        firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                        error_num1 = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        error_num1 = true;
                    }
                }
                while(error_num2)
                {
                    try
                    {
                        Console.WriteLine("Now enter another number(must be a double):");
                        secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                        error_num2 = false;
                    }catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        error_num2 = true;
                    }
                   
                }
                while (error_opt)
                {
                    try
                    {
                        Console.WriteLine("What should I do with the 2 values?");
                        operation = Console.ReadLine();
                        result = calculatorEngine.Calculate(operation.ToLower(), firstNumber, secondNumber);
                        error_opt = false;
                    }catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        error_opt = true;
                    }
                }      
                Console.WriteLine("Would you like to do another calculation?(Press y to start over)");
                startOver = Console.ReadLine();
            }

        }
    }
}
