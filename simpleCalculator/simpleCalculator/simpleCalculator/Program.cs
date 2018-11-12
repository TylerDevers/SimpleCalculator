using System;

namespace simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Input numbers and the operation");
                double firstNumber = inputConverter.StringToNumber(Console.ReadLine());
                double secondNumber = inputConverter.StringToNumber(Console.ReadLine());
                string operation = Console.ReadLine();
                
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            catch(Exception ex)
            {
                //TODO start loggin exceptions
                Console.WriteLine(ex.Message);
            }
        }
    }
}
