using System;
using System.Reflection;


public class Program
{
    static void Main()
    {
        
        Console.WriteLine("Displaying Documentation Attributes:");
        AttributeReader.DisplayDocumentationAttributes(typeof(Class));

       
        Console.WriteLine("Executing Methods by Author 'Thomas Hardy ':");
        MethodExecutor.ExecuteMethodsByAuthor(typeof(Class), "Thomas Hardy ");
        Console.ReadKey();
    }
}
