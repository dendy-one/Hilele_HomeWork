using System;
using System.Linq;

namespace MyProject
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public int Multiply(int a, int b) => a * b;

        public double Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();
            return (double)a / b;
        }

        public double Average(int[] numbers)
        {
            if (numbers.Length == 0) throw new InvalidOperationException("Array is empty");
            return numbers.Average();
        }

        public int Max(int[] numbers)
        {
            if (numbers.Length == 0) throw new InvalidOperationException("Array is empty");
            return numbers.Max();
        }

        public int[] Sort(int[] numbers) => numbers.OrderBy(n => n).ToArray();
    }
}
