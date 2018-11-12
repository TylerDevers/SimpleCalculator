using System;

namespace simpleCalculator
{
    public class InputConverter
    {
        public double StringToNumber(string sample)
        {
            Double.TryParse(sample, out double convertedString);

            return convertedString;
            
        }
    }
}
