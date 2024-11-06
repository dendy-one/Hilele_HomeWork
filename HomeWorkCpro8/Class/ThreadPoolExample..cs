using System;
using System.Threading;

namespace HomeWorkCpro8
{
    public static class ThreadPoolExample
    {
        public static void Run()
        {
            for (int i = 1; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(PrintTaskInfo, i);
            }

            Console.WriteLine("Main thread finished.");
        }

        private static void PrintTaskInfo(object taskNumber)
        {
            Console.WriteLine($"Task {taskNumber} is running on thread {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
