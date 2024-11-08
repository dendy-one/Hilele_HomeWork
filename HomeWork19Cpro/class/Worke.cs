using System;
using System.Threading;

class Worke
{
    private ManualResetEvent startEvent;
    private SharedResource sharedResource;

    public Worke(ManualResetEvent startEvent, SharedResource sharedResource)
    {
        this.startEvent = startEvent;
        this.sharedResource = sharedResource;
    }

    public void ThreadWork()
    {
        // Очікування на стартовий сигнал
        Console.WriteLine($"{Thread.CurrentThread.Name} is waiting for the start signal...");
        startEvent.WaitOne();

        // Отримання доступу до спільного ресурсу
        sharedResource.Access();
    }
}
