class Task1
{
    public static async Task RunAsync()
    {
        var task1 = Task.Run(() => PrintName("Задача 1"));
        var task2 = Task.Run(() => CalculateSum(10, 20));
        var task3 = Task.Run(() => DelayedAction());

        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("Всі задачі завершено.");
    }

    static void PrintName(string name)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{name}: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(500);
        }
    }

    static void CalculateSum(int a, int b)
    {
        Console.WriteLine($"Сума {a} і {b} дорівнює {a + b}");
    }

    static async Task DelayedAction()
    {
        await Task.Delay(2000);
        Console.WriteLine("Затримана дія завершена.");
    }
}