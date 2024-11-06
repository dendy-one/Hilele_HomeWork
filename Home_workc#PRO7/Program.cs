using ComplexNumbers;
using GeometryLibrary;





namespace Home_workcPro7
{
    class Program
    {
        static void Main(string[] args)
        {
            var complex1 = new ComplexNumber(2, 3);
            var complex2 = new ComplexNumber(1, -2);

            var sum = complex1 + complex2;
            var difference = complex1 - complex2;
            var product = complex1 * complex2;
            var quotient = complex1 / complex2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");

            Circle circle = new Circle(5);
            Console.WriteLine(circle.ToString());

            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine(rectangle.ToString());

            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine(triangle.ToString());

            Console.WriteLine($"Circle: {circle}, Area: {circle.Area()}, Perimeter: {circle.Perimeter()}");
            Console.WriteLine($"Rectangle: {rectangle}, Area: {rectangle.Area()}, Perimeter: {rectangle.Perimeter()}");
            Console.WriteLine($"Triangle: {triangle}, Area: {triangle.Area()}, Perimeter: {triangle.Perimeter()}");
        }
    }
}
