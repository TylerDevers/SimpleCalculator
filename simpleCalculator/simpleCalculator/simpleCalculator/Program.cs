using System;

namespace simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InputConverter inputConverter = new InputConverter();
            CalculatorEngine calculatorEngine = new CalculatorEngine();

            float firstNumber = inputConverter.StringToNumber(Console.ReadLine);
            float secondNumber = inputConverter.StringToNumber(Console.ReadLine);
        }
    }
}
