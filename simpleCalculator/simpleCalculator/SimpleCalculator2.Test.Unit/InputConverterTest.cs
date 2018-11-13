using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using simpleCalculator;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.StringToNumber(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringIntoDouble()
        {
            string inputNumber = "*";
            double convertedNumber = _inputConverter.StringToNumber(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }
    }
}
