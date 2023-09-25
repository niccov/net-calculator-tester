using net_calculator_tester;

namespace CalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test(Description = "Test addizione tra 2 valori")]
        [TestCase(-10, 83)]
        [TestCase(-560, -32)]
        [TestCase(0, 57)]

        public void Add_Test(float number1, float number2)
        {
            Assert.DoesNotThrow(() => Calculator.Add(number1, number2));
        }


        [Test(Description = "Test moltiplicazione tra 2 valori")]
        [TestCase(-25, 64)]
        [TestCase(-1, -54)]
        [TestCase(0, 37)]
        public void Multiply_Test(float number1, float number2)
        {
            Assert.DoesNotThrow(() => Calculator.Multiply(number1, number2));
        }

        [Test(Description = "Test sottrazione tra 2 valori")]
        [TestCase(-64, 43)]
        [TestCase(-2, -26)]
        [TestCase(0, -93)]
        public void Subtract_Test(float number1, float number2)
        {
            Assert.DoesNotThrow(() => Calculator.Subtract(number1, number2));
        }

        [Test(Description = "Test divisione tra 2 valori")]
        [TestCase(-19, 73)]
        [TestCase(0, 54)]
        [TestCase(0, 84)]

        public void Divide_Test(float number1, float number2)
        {
            Assert.DoesNotThrow(() => Calculator.Divide(number1, number2));
        }
    }
}