using NUnit.Framework;
using FizzBuzz_Library;

namespace FizzBuzz_UnitTest
{
    [TestFixture]
    public class Tests
    {
        FizzBuzzer fizzBuzzer;

        [SetUp]
        public void Setup()
        {
            fizzBuzzer = new FizzBuzzer();
        }

        [Test]
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(12, ExpectedResult = "Fizz")]
        [TestCase(30, ExpectedResult = "FizzBuzz")]
        [TestCase(43, ExpectedResult = "43")]
        [TestCase(157, ExpectedResult = "157")]
        [TestCase(50, ExpectedResult = "Buzz")]
        [TestCase(72, ExpectedResult = "Fizz")]
        [TestCase(60, ExpectedResult = "FizzBuzz")]
        public string FizzBuzzer_WhenNumberPassed_ReturnsString(int input) => fizzBuzzer.GetBuzzer(input);
    }
}