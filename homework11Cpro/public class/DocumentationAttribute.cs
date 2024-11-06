using System;

[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
public class DocumentationAttribute : Attribute
{
    public string Author { get; }
    public string Version { get; }
    public string Description { get; }

    public DocumentationAttribute(string author, string version)
    {
        Author = author;
        Version = version;
    }

    public DocumentationAttribute(string author, string version, string description)
    {
        Author = author;
        Version = version;
        Description = description;
    }
}
