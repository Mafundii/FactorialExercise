using RecursionFactorialApp;

namespace RecursionExerciseTests
{
    public class Tests
    {
        [TestCase(1, 1)]
        [TestCase(0, 1)]
        public void Given0Or1_Factorial_Returns1(int input, int result)
        {
            Assert.That(Program.RecFactorial(input), Is.EqualTo(result));
        }

        [TestCase(-1)]
        public void GivenANegativeNumber_Factorial_ReturnsArgumentOutOfRangeException(int input)
        {
            Assert.Throws<ArgumentNullException>(() => Program.RecFactorial(input));
        }

        [TestCase(13)]
        public void GivenNumberAbove13_Factorial_ReturnsStackOverflow(int input)
        {
            Assert.Throws<StackOverflowException>(() => Program.RecFactorial(input));
        }
    }
}