using System;
using System.Threading;










class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;


        Console.WriteLine("Факторіал 5: " + MathHelper.Factorial(5));
        Console.WriteLine("НСД 11 і 20: " + MathHelper.GCD(11, 20));
        Console.WriteLine("НСК 1 і 2: " + MathHelper.LCM(1, 2));

      
        ApplicationSettings appSettings = new ApplicationSettings
        {
            AppName = "Моя Програма",
            Version = "1.0",
            DbSettings =
            {
                ConnectionString = "Server=myServer;Database=myDB;",
                Timeout = 30
            }
        };
        Console.WriteLine(appSettings.GetFullSettings());

       
        Storage<int> intStorage = new Storage<int>();
        intStorage.SetItem(123);
        Console.WriteLine("Збережене ціле число: " + intStorage.GetItem());

        Storage<string> stringStorage = new Storage<string>();
        stringStorage.SetItem("Тестовий рядок");
        Console.WriteLine("Збережений рядок: " + stringStorage.GetItem());
        Console.WriteLine("натисніть кнопку щоб запустить таймер");

        Console.ReadKey();

        
        Timer timer = new Timer();
        timer.OnTimeElapsed += () => Console.WriteLine("Таймер завершився!");
        timer.Start(5); 
    }
}