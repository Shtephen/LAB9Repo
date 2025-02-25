using Xunit;
using MyApp;

namespace MyApp.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        public void Factorial_ReturnsCorrectValue(int input, long expected)
        {
            long result = Program.Factorial(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Factorial_NegativeInput_ThrowsArgumentOutOfRangeException()
        {
            int negativeInput = -1;
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => Program.Factorial(negativeInput));
            Assert.Equal("Число должно быть неотрицательным. (Parameter 'n')", exception.Message);
        }
    }
}