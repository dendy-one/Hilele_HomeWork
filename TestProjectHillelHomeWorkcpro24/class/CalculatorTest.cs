using System;
using Xunit;
using TestProjectHillelHomeWorkcpro24;
using MyProject;

namespace TestProjectHillelHomeWorkcpro24
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            var calculator = new Calculator();
            Assert.Equal(5, calculator.Add(2, 3));
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference()
        {
            var calculator = new Calculator();
            Assert.Equal(1, calculator.Subtract(3, 2));
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct()
        {
            var calculator = new Calculator();
            Assert.Equal(6, calculator.Multiply(2, 3));
        }

        [Fact]
        public void Divide_ReturnsCorrectQuotient()
        {
            var calculator = new Calculator();
            Assert.Equal(2, calculator.Divide(6, 3));
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(6, 0));
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, 2)]
        [InlineData(new[] { -1, -2, -3 }, -2)]
        public void Average_CalculatesCorrectAverage(int[] numbers, double expected)
        {
            var calculator = new Calculator();
            Assert.Equal(expected, calculator.Average(numbers));
        }

        [Fact]
        public void Average_EmptyArray_ThrowsException()
        {
            var calculator = new Calculator();
            Assert.Throws<InvalidOperationException>(() => calculator.Average(new int[] { }));
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, 3)]
        [InlineData(new[] { -1, -2, -3 }, -1)]
        [InlineData(new[] { 1 }, 1)]
        public void Max_ReturnsLargestNumber(int[] numbers, int expected)
        {
            var calculator = new Calculator();
            Assert.Equal(expected, calculator.Max(numbers));
        }

        [Fact]
        public void Max_EmptyArray_ThrowsException()
        {
            var calculator = new Calculator();
            Assert.Throws<InvalidOperationException>(() => calculator.Max(new int[] { }));
        }

        [Theory]
        [InlineData(new[] { 3, 1, 2 }, new[] { 1, 2, 3 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new[] { 1 }, new[] { 1 })]
        public void Sort_ReturnsSortedArray(int[] numbers, int[] expected)
        {
            var calculator = new Calculator();
            Assert.Equal(expected, calculator.Sort(numbers));
        }
    }
}
