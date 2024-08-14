using System;

public interface IMovable
{
    void Move(int deltaX, int deltaY);
}

public abstract class Shape : IMovable
{
    public abstract void Move(int deltaX, int deltaY);
}

public class Circle : Shape
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public double Radius { get; set; }

    public Circle(int x, int y, double radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }

    public override void Move(int deltaX, int deltaY)
    {
        X += deltaX;
        Y += deltaY;
        Console.WriteLine($"Коло перенесено на ({X}, {Y})");
    }
}

public class Rectangle : Shape
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public double Width { get; private set; }
    public double Height { get; private set; }

    public Rectangle(int x, int y, double width, double height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    public override void Move(int deltaX, int deltaY)
    {
        X += deltaX;
        Y += deltaY;
        Console.WriteLine($"Прямокутник переміщено до ({X}, {Y})");
    }

    public void Resize(Vector vector)
    {
        Width += vector.X;
        Height += vector.Y;
        Console.WriteLine($"Розмір прямокутника змінено на {Width} x {Height}");
    }
}

public struct Vector
{
    public double X { get; set; }
    public double Y { get; set; }

    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double Length()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;


        Circle circle = new Circle(0, 0, 5);
        circle.Move(10, 15); 

        
        Rectangle rectangle = new Rectangle(0, 0, 20, 10);
        rectangle.Move(5, 5); 

      
        Vector resizeVector = new Vector(10, 20);
        rectangle.Resize(resizeVector); 

        
        Console.WriteLine($"Довжина вектора: {resizeVector.Length()}");
        Console.ReadKey();
    }
}

