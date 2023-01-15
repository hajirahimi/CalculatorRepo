using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorEngine
    {
        public static double Calculate(double firstNumber, double secondNumber, string operation)
        {
            double result;
            switch (operation.ToLower())
            {
                case "+":
                case "plus":
                case "add":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                case "subtract":
                case "minus":
                    result= firstNumber - secondNumber;
                    break;
                case "*":
                case "mulitple":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                case "divide":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    throw new ArgumentException("The opertion is not correct ");
            }
            return result;
        }
    }
}