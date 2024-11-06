using System;

public class AttributeReader
{
    public static void DisplayDocumentationAttributes(Type type)
    {
        foreach (var method in type.GetMethods())
        {
            var attribute = (DocumentationAttribute)Attribute.GetCustomAttribute(method, typeof(DocumentationAttribute));
            if (attribute != null)
            {
                Console.WriteLine($"Method: {method.Name}");
                Console.WriteLine($"Author: {attribute.Author}");
                Console.WriteLine($"Version: {attribute.Version}");
                if (!string.IsNullOrEmpty(attribute.Description))
                {
                    Console.WriteLine($"Description: {attribute.Description}");
                }
                Console.WriteLine();
            }
        }
    }
}
