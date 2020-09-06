using System;
using System.Text;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result;
            StringBuilder strbuild = new StringBuilder();
            switch (argOperation.ToLower())
            {
                case "add":
                case "plus":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    strbuild.Append(String.Format("The value {0} plus the value {1} is equal to {2}", Math.Round(argFirstNumber, 2), Math.Round(argSecondNumber, 2), Math.Round(result, 2)));
                    Console.WriteLine(strbuild.ToString());
                    break;
                case "subtract":
                case "minus":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    strbuild.Append(String.Format("The value {0} minus the value {1} is equal to {2}", Math.Round(argFirstNumber, 2), Math.Round(argSecondNumber, 2), Math.Round(result, 2)));
                    Console.WriteLine(strbuild.ToString());
                    break;
                case "multiply":
                case "times":
                case "*":
                    result = argFirstNumber * argSecondNumber;
                    strbuild.Append(String.Format("The value {0} times the value {1} is equal to {2}", Math.Round(argFirstNumber, 2), Math.Round(argSecondNumber, 2), Math.Round(result, 2)));
                    Console.WriteLine(strbuild.ToString());
                    break;
                case "divide":
                case "/":
                    result = argFirstNumber / argSecondNumber;
                    strbuild.Append(String.Format("The value {0} divided the value {1} is equal to {2}", Math.Round(argFirstNumber, 2), Math.Round(argSecondNumber, 2), Math.Round(result, 2)));
                    Console.WriteLine(strbuild.ToString());
                    break;
                default:
                    strbuild.Append("+-------------------+" +
                                    "\nUnsupported operator: " + argOperation +
                                    "\nList of supported operators(as of now):" +
                                    "\n1.Addition: \"plus\",\"add\",\"+\"" +
                                    "\n2.Subtraction: \"minus\",\"subtract\",\"-\"" +
                                    "\n3.Multiplication: \"multiply\",\"times\",\"*\"" +
                                    "\n4.Division: \"divide\",\"\\\"" + "\n");
                    throw new InvalidOperationException(strbuild.ToString());
            }
            return result;
        }

    }
}