using System;

namespace HomeWorkCpro8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Завдання 1
            SimpleThreadExample.Run();

            // Завдання 2
            ThreadPoolExample.Run();

            // Завдання 3
            SynchronizedCounterExample.Run();

            // Завдання 4
            LimitedConcurrencyExample.Run();
            Console.ReadKey();
        }
    }
}
