using System;

namespace simpleCalculator
{
    public class InputConverter
    {
        public double StringToNumber(string argTextInput)
        {
            //assigment and bool check at the same time
            if (!Double.TryParse(argTextInput, out double convertedString))
            {
                throw new ArgumentException("Expected a numeric value");
            }

            return convertedString;

            
        }
    }
}
