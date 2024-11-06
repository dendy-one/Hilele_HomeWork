using System;

namespace ComplexNumbers

{
    public class ComplexNumber
    {
        public double Real { get; }
        public double Imaginary { get; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            double realPart = a.Real * b.Real - a.Imaginary * b.Imaginary;
            double imaginaryPart = a.Real * b.Imaginary + a.Imaginary * b.Real;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            double denominator = b.Real * b.Real + b.Imaginary * b.Imaginary;
            double realPart = (a.Real * b.Real + a.Imaginary * b.Imaginary) / denominator;
            double imaginaryPart = (a.Imaginary * b.Real - a.Real * b.Imaginary) / denominator;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
