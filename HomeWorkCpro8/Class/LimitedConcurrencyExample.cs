using System;
using System.Threading;

namespace HomeWorkCpro8
{
    public static class LimitedConcurrencyExample
    {
        private static readonly Semaphore semaphore = new Semaphore(2, 2); 

        public static void Run()
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread limitedThread = new Thread(UseSharedResource);
                limitedThread.Start(i);
            }

            Console.WriteLine("Main thread finished.");
        }

        private static void UseSharedResource(object id)
        {
            Console.WriteLine($"Thread {id} is waiting to access the shared resource.");
            semaphore.WaitOne(); 

            try
            {
                Console.WriteLine($"Thread {id} is using the shared resource.");
                Thread.Sleep(1000); 
            }
            finally
            {
                Console.WriteLine($"Thread {id} is releasing the shared resource.");
                semaphore.Release(); 
            }
        }
    }
}
