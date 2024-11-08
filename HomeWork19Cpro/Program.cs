using System;
using System.Threading;

class Program
{
    private static ManualResetEvent startEvent = new ManualResetEvent(false);
    private static SharedResource sharedResource = new SharedResource();

    static void Main()
    {
        // Створимо декілька потоків
        Thread[] threads = new Thread[5];
        for (int i = 0; i < threads.Length; i++)
        {
            Worke worker = new Worke(startEvent, sharedResource);
            threads[i] = new Thread(new ThreadStart(worker.ThreadWork));
            threads[i].Name = "Thread " + i;
            threads[i].Start();
        }

        // Зачекаємо трохи перед подачею сигналу
        Console.WriteLine("Main thread sleeping for 2 seconds...");
        Thread.Sleep(2000);

        // Подати сигнал всім потокам для початку роботи
        Console.WriteLine("Main thread signaling threads to start...");
        startEvent.Set();

        // Дочекаємося завершення всіх потоків
        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine("Main thread exiting.");
    }
}
