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
            Console.WriteLine("You can press o at anytime to see the possible operators for the calculation");

            while (startOver.Equals("y"))
            {
                StringBuilder str_options = new StringBuilder();
                str_options.Append( "List of supported operators(as of now):" +
                                    "\n1.Addition: \"plus\",\"add\",\"+\"" +
                                    "\n2.Subtraction: \"minus\",\"subtract\",\"-\"" +
                                    "\n3.Multiplication: \"multiply\",\"times\",\"*\"" +
                                    "\n4.Division: \"divide\",\"\\\"" +
                                    "\n5.Square Root(first value):\"root1\",\"square root1\",\"sqr1\"" +
                                    "\n6.Square Root(second value):\"root2\",\"square root2\",\"sqr2\"" +
                                    "\n7.Power:\"power\",\"pow\"" +
                                    "\n8(*).Bitwise AND: \"and\",\"&\"" +
                                    "\n9(*).Bitwise OR: \"or\",\"|\"" +
                                    "\n10(*).Bitwise XOR: \"xor\",\"^\"" +
                                    "\n11(*).Right shift: \"rightshift\",\">>\"" +
                                    "\n12(*).Left shift: \"leftshift\",\"<<\"" +
                                    "\n(*) Expect a floating point value to be truncated" + "\n");
                bool error_num1 = true;
                bool error_num2 = true;
                bool error_opt = true;
                while (error_num1)
                {
                    try
                    {
                        Console.WriteLine("Please enter a number:");
                        string reader = Console.ReadLine();
                        if (reader == "o")
                        {
                            Console.WriteLine(str_options);
                        }
                        else
                        {
                            firstNumber = inputConverter.ConvertInputToNumeric(reader);
                            error_num1 = false;
                        }
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
                        Console.WriteLine("Now enter another number:");
                        string reader = Console.ReadLine();
                        if (reader == "o")
                        {
                            Console.WriteLine(str_options);
                        }
                        else
                        {
                            secondNumber = inputConverter.ConvertInputToNumeric(reader);
                            error_num2 = false;
                        }   
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
                        if (operation == "o")
                        {
                            Console.WriteLine(str_options);
                        }
                        else
                        {
                            result = calculatorEngine.Calculate(operation.ToLower(), firstNumber, secondNumber);
                            error_opt = false;
                        }
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
