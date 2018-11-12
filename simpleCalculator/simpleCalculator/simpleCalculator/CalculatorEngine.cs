using System;

namespace simpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result;

            switch(argOperation.ToLower())
            {
                case "+":
                case "add":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "-":
                case "subtract":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "/":
                case "divide":
                    result = argFirstNumber / argSecondNumber;
                    break;
                case "*":
                case "x":
                case "multiply":
                    result = argFirstNumber * argSecondNumber;
                    break;
                default:
                    throw new InvalidOperationException("operation not allowed");
            }
            return result;
        }
    }
}
