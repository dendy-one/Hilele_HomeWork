using System;
using System.Reflection;


public class Program
{
    static void Main()
    {
        
        Console.WriteLine("Displaying Documentation Attributes:");
        AttributeReader.DisplayDocumentationAttributes(typeof(MyClass));

       
        Console.WriteLine("Executing Methods by Author 'Thomas Hardy ':");
        MethodExecutor.ExecuteMethodsByAuthor(typeof(MyClass), "Thomas Hardy ");
        Console.ReadKey();
    }
}
