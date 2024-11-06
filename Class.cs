using System;

public class MyClass
{
    [Documentation("Thomas Wyatt", "1.0")]
    public void MethodOne()
    {
        Console.WriteLine("MethodOne executed.");
    }

    [Documentation("William Shakespeare", "1.1")]
    public void MethodTwo()
    {
        Console.WriteLine("MethodTwo executed.");
    }

    [Documentation("Thomas Hardy ", "1.2", "This method performs a specific task.")]
    public void MethodThree()
    {
        Console.WriteLine("MethodThree executed.");
    }
}
