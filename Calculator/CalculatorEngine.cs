using System;
using System.Text;

namespace CalculatorLib
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
                case "root1":
                case "square root1":
                case "sqr1":
                    result = Math.Sqrt(argFirstNumber);
                    strbuild.Append(String.Format("The square root of the first value you entered, {0}, is equal to {1}", Math.Round(argFirstNumber, 2), Math.Round(result, 2)));
                    Console.WriteLine(strbuild.ToString());
                    break;
                case "root2":
                case "square root2":
                case "sqr2":
                    result = Math.Sqrt(argSecondNumber);
                    strbuild.Append(String.Format("The square root of the second value you entered, {0}, is equal to {1}", Math.Round(argSecondNumber, 2), Math.Round(result, 2)));
                    Console.WriteLine(strbuild.ToString());
                    break;
                case "power":
                case "pow":
                    result = Math.Pow(argFirstNumber,argSecondNumber);
                    strbuild.Append(String.Format("The value {0} to the power of the value {1} is equal to {2}", Math.Round(argFirstNumber, 2), Math.Round(argSecondNumber, 2), Math.Round(result, 2)));
                    Console.WriteLine(strbuild.ToString());
                    break;
                case "&":
                case "and":
                    result = (int)argFirstNumber & (int)argSecondNumber;
                    strbuild.Append(String.Format("The bitwise AND value of {0} and {1} is equal to {2}", (int)argFirstNumber, (int)argSecondNumber, result));
                    Console.WriteLine(strbuild.ToString());
                    break;
                case "|":
                case "or":
                    result = (int)argFirstNumber | (int)argSecondNumber;
                    strbuild.Append(String.Format("The bitwise OR value of {0} and {1} is equal to {2}", (int)argFirstNumber, (int)argSecondNumber, result));
                    Console.WriteLine(strbuild.ToString());
                    break;
                case "^":
                case "xor":
  
                    result = (int)argFirstNumber ^ (int)argSecondNumber;
                    strbuild.Append(String.Format("The bitwise XOR value of {0} and {1} is equal to {2}", (int)argFirstNumber, (int)argSecondNumber, result));
                    Console.WriteLine(strbuild.ToString());
                    break;
                case ">>":
                case "rightshift":
                    result = (int)argFirstNumber >> (int)argSecondNumber;
                    if ((int)argSecondNumber == 1)
                    {
                        strbuild.Append(String.Format("The value {0} shifted {1} unit to the right is equal to {2}", (int)argFirstNumber, (int)argSecondNumber, result));
                        Console.WriteLine(strbuild.ToString());
                    }
                    else
                    {
                        strbuild.Append(String.Format("The value {0} shifted {1} units to the right is equal to {2}", (int)argFirstNumber, (int)argSecondNumber, result));
                        Console.WriteLine(strbuild.ToString());
                    }
                    break;
                case "<<":
                case "leftshift":
                    result = (int)argFirstNumber << (int)argSecondNumber;
                    if ((int)argSecondNumber == 1)
                    {
                        strbuild.Append(String.Format("The value {0} shifted {1} unit to the left is equal to {2}", (int)argFirstNumber, (int)argSecondNumber, result));
                        Console.WriteLine(strbuild.ToString());
                    }
                    else
                    {
                        strbuild.Append(String.Format("The value {0} shifted {1} units to the left is equal to {2}", (int)argFirstNumber, (int)argSecondNumber, result));
                        Console.WriteLine(strbuild.ToString());
                    }
                    break;
                default:
                    strbuild.Append("+-------------------+" +
                                    "\nUnsupported operator: " + argOperation +
                                    "\nList of supported operators(as of now):" +
                                    "\n1.Addition: \"plus\",\"add\",\"+\"" +
                                    "\n2.Subtraction: \"minus\",\"subtract\",\"-\"" +
                                    "\n3.Multiplication: \"multiply\",\"times\",\"*\"" +
                                    "\n4.Division: \"divide\",\"\\\"" + 
                                    "\n5.Square Root(first value):\"root1\",\"square root1\",\"sqr1\""+
                                    "\n6.Square Root(second value):\"root2\",\"square root2\",\"sqr2\"" +
                                    "\n7.Power:\"power\",\"pow\""+
                                    "\n8(*).Bitwise AND: \"and\",\"&\"" +
                                    "\n9(*).Bitwise OR: \"or\",\"|\"" +
                                    "\n10(*).Bitwise XOR: \"xor\",\"^\"" +
                                    "\n11(*).Right shift: \"rightshift\",\">>\"" +
                                    "\n12(*).Left shift: \"leftshift\",\"<<\"" +
                                    "\n(*) Expect a floating point value to be truncated" + "\n");
                    throw new InvalidOperationException(strbuild.ToString());
            }
            return result;
        }

    }
}