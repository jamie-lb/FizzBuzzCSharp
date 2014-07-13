using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzConverterTests
    {
        FizzBuzzConverter converter = new FizzBuzzConverter();

        [TestMethod]
        public void Converting1ShouldReturn1()
        {
            AssertValueWasConverted(1);
        }

        [TestMethod]
        public void Converting2ShouldReturn2()
        {
            AssertValueWasConverted(2);
        }

        private void AssertValueWasConverted(Int32 input)
        {
            String convertedValue = converter.ConvertNumber(input);
            Assert.AreEqual(input.ToString("D"), convertedValue);
        }

        [TestMethod]
        public void Converting3ShouldReturnFizz()
        {
            String convertedValue = converter.ConvertNumber(3);
            Assert.AreEqual("Fizz", convertedValue);
        }

        [TestMethod]
        public void Converting5ShouldReturnBuzz()
        {
            String convertedValue = converter.ConvertNumber(5);
            Assert.AreEqual("Buzz", convertedValue);
        }

        [TestMethod]
        public void Converting30ShouldReturnFizzBuzz()
        {
            String convertedValue = converter.ConvertNumber(30);
            Assert.AreEqual("FizzBuzz", convertedValue);
        }

        [TestMethod]
        public void Converting35ShouldReturnFizzBuzz()
        {
            String convertedValue = converter.ConvertNumber(35);
            Assert.AreEqual("FizzBuzz", convertedValue);
        }

        [TestMethod]
        public void Converting53ShouldReturnFizzBuzz()
        {
            String convertedValue = converter.ConvertNumber(53);
            Assert.AreEqual("FizzBuzz", convertedValue);
        }

        [TestMethod]
        public void Converting98ShouldReturn98()
        {
            AssertValueWasConverted(98);
        }
    }
}
