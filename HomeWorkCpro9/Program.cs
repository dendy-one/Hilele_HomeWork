using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MultitaskingExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task1.RunAsync();
            await Task2.RunAsync();
            await Task3.RunAsync();
        }
    }
}
