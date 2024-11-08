using System;
using System.Threading;

class SharedResource
{
    private static Mutex resourceMutex = new Mutex();
    private static Random random = new Random();
    private int resourceValue = 0;

    public void Access()
    {
        // Очікування на отримання доступу до Mutex
        Console.WriteLine($"{Thread.CurrentThread.Name} is waiting to access the shared resource...");
        resourceMutex.WaitOne();

        try
        {
            // Вхід до критичної секції
            Console.WriteLine($"{Thread.CurrentThread.Name} has entered the critical section.");

            // Імітація роботи з спільним ресурсом
            int initialValue = resourceValue;
            Thread.Sleep(random.Next(500, 1000));
            resourceValue = initialValue + 1;

            // Вивід результату
            Console.WriteLine($"{Thread.CurrentThread.Name} updated shared resource to {resourceValue}.");
        }
        finally
        {
            // Вихід з критичної секції та вивільнення Mutex
            Console.WriteLine($"{Thread.CurrentThread.Name} is leaving the critical section.");
            resourceMutex.ReleaseMutex();
        }
    }
}
