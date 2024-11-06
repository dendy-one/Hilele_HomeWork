using System;
using System.Threading;

namespace HomeWorkCpro8
{
    public static class SimpleThreadExample
    {
        public static void Run()
        {
            Thread thread1 = new Thread(PrintName);
            Thread thread2 = new Thread(PrintName);

            thread1.Start("Thread 1");
            thread2.Start("Thread 2");

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Main thread finish.");
        }

        private static void PrintName(object name)
        {
            Console.WriteLine($"Hello from {name}");
        }
    }
}
