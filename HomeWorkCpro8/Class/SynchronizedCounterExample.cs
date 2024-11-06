using System;
using System.Threading;

namespace HomeWorkCpro8
{
    public static class SynchronizedCounterExample
    {
        private static int counter = 0;
        private static readonly object lockObject = new object();

        public static void Run()
        {
            Thread incrementThread1 = new Thread(IncrementCounter);
            Thread incrementThread2 = new Thread(IncrementCounter);

            incrementThread1.Start();
            incrementThread2.Start();

            incrementThread1.Join();
            incrementThread2.Join();

            Console.WriteLine($"Final counter value: {counter}");
        }

        private static void IncrementCounter()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (lockObject)
                {
                    counter++;
                }
            }
        }
    }
}
