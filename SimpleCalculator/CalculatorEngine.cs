using System;
using System.Text;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result;
            StringBuilder strbuild = new StringBuilder();
                switch (argOperation.ToLower())
                {
                    case "add":
                    case "plus":
                    case "+":
                        result = argFirstNumber + argSecondNumber;
                        strbuild.Append(String.Format("{0} plus {1} equals {2}", Math.Round(argFirstNumber,2), Math.Round(argSecondNumber,2), Math.Round(result, 2)));
                        Console.WriteLine(strbuild.ToString());
                        break;
                    case "subtract":
                    case "minus":
                    case "-":
                        result = argFirstNumber - argSecondNumber;
                        strbuild.Append(String.Format("{0} minus {1} equals {2}", Math.Round(argFirstNumber,2), Math.Round(argSecondNumber,2), Math.Round(result, 2)));
                        Console.WriteLine(strbuild.ToString());
                        break;
                    case "multiply":
                    case "times":
                    case "*":
                        result = argFirstNumber * argSecondNumber;
                        strbuild.Append(String.Format("{0} times {1} equals {2}", Math.Round(argFirstNumber,2), Math.Round(argSecondNumber,2), Math.Round(result, 2)));
                        Console.WriteLine(strbuild.ToString());
                        break;
                    case "divide":
                    case "/":
                        result = argFirstNumber / argSecondNumber;
                        strbuild.Append(String.Format("{0} divided by {1} equals {2:}", Math.Round(argFirstNumber,2), Math.Round(argSecondNumber,2), Math.Round(result, 2)));
                        Console.WriteLine(strbuild.ToString());
                        break;
                default:
                    strbuild.Append("+-------------------+"+
                                    "\nUnsupported operator: "+argOperation+
                                    "\nList of supported operators(as of now):"+
                                    "\n1.Addition: \"plus\",\"add\",\"+\""+
                                    "\n2.Subtraction: \"minus\",\"subtract\",\"-\""+
                                    "\n3.Multiplication: \"multiply\",\"times\",\"*\""+
                                    "\n4.Division: \"divide\",\"\\\""+"\n");
                        throw new InvalidOperationException(strbuild.ToString());
                }
            return result;
        }

    }
}
