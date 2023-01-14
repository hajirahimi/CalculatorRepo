using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var converter = new Converter();
                var calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Enter first number");
                double firstNumber = Converter.ConverterToDouble(Console.ReadLine());
                Console.WriteLine("Enter seond number");
                double secondNumber = Converter.ConverterToDouble(Console.ReadLine());
                Console.WriteLine("Enter function");
                string operation = Console.ReadLine();

                double result = CalculatorEngine.Calculate(firstNumber, secondNumber, operation);
                Console.WriteLine("{0} {2} {1} = {3}", firstNumber, secondNumber, operation, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}