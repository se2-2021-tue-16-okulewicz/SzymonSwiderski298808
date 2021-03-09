using NUnit.Framework;

namespace ClassLibrary2.Tests
{
    public class StringCalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EmptyStringTest()
        {
            Calculator calc = new Calculator();
            string emtyString = "";
            int output = calc.Calculate(emtyString);
            int expectedResult = 0;
            Assert.AreEqual(expectedResult, output);
        }
        [Test]
        public void SingleNumberStringTest()
        {
            Calculator calc = new Calculator();

            int expectedResult = 1234567890;
            string emtyString = "1234567890";
            int output = calc.Calculate(emtyString);
            Assert.AreEqual(expectedResult, output);
        }
        [Test]
        public void commaOperatorTest()
        {
            Calculator calc = new Calculator();

            int expectedResult = 12345;
            string emtyString = "12300,45";
            int output = calc.Calculate(emtyString);
            Assert.AreEqual(expectedResult, output);
        }
        [Test]
        public void newLineOperatorTest()
        {
            Calculator calc = new Calculator();

            int expectedResult = 12345;
            string emtyString = "12300\n45";
            int output = calc.Calculate(emtyString);
            Assert.AreEqual(expectedResult, output);
        }
    }
}