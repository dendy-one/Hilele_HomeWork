using System;
class Task3
{
    public static async Task RunAsync()
    {
        await DelayedAction();
    }

    static async Task DelayedAction()
    {
        await Task.Delay(2000);
        Console.WriteLine("Затримана дія завершена.");
    }
}