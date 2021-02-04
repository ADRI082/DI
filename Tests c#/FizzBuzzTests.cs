using NUnit.Framework;

namespace PicassoTest.Tests
{
    public class FizzBuzzTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void number_divisible_per_3_returns_Fizz()
        {
            Assert.That(FizzBuzz.GetOutput(3), Is.EqualTo("Fizz"));
        }

        [Test]
        public void number_divisible_per_5_return_Buzz()
        {
            Assert.That(FizzBuzz.GetOutput(5), Is.EqualTo("Buzz"));
        }

        [Test]
        public void number_divisible_per_3_and_5_return_FizzBuzz()
        {
            Assert.That(FizzBuzz.GetOutput(15), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void number_is_not_divisible_per_3_or_5_return_String_number()
        {
            var number = 2;

            Assert.That(FizzBuzz.GetOutput(number), Is.EqualTo(number.ToString()));
        }

    }
}
