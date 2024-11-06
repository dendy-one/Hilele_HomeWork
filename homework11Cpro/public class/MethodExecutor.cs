using System;

public class MethodExecutor
{
    public static void ExecuteMethodsByAuthor(Type type, string author)
    {
        foreach (var method in type.GetMethods())
        {
            var attribute = (DocumentationAttribute)Attribute.GetCustomAttribute(method, typeof(DocumentationAttribute));
            if (attribute != null && attribute.Author == author)
            {
                method.Invoke(Activator.CreateInstance(type), null);
            }
        }
    }
}
