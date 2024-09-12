using System.Threading;
using System;

public class Timer
{
    public event Action OnTimeElapsed;

    public void Start(int seconds)
    {
        Console.WriteLine($"Таймер запущено на {seconds} секунд...");
        Thread.Sleep(seconds * 1000);
        OnTimeElapsed?.Invoke();
    }
}