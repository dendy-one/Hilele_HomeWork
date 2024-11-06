using System;
using System.Collections.Generic;
using System.Linq;


public delegate void TemperatureChangedEventHandler(double newTemperature);

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Thermostat thermostat = new Thermostat();
        thermostat.TemperatureChanged += (newTemp) =>
        {
            Console.WriteLine($"Нова температура: {newTemp}°C");
        };
        thermostat.CurrentTemperature = 25.5;

       
        List<int> numbers = new List<int> { 10, 15, 20, 25, 30, 35, 40 };
        var evenNumbers = numbers.Filter(n => n % 2 == 0);
        var greaterThanThreshold = numbers.Filter(n => n > 25);
        Console.WriteLine("Парні числа:");
        Console.WriteLine(string.Join(", ", evenNumbers));
        Console.WriteLine($"Числа більше 25:");
        Console.WriteLine(string.Join(", ", greaterThanThreshold));

        int[] array1 = { 10, 20, 30, 40, 50 };
        int[] array2 = { 5, 15, 25, 35 };
        Console.WriteLine($"Середнє значення array1: {array1.Average()}");
        Console.WriteLine($"Середнє значення array2: {array2.Average()}");

       
        List<double> measurements = new List<double>();
        Sensor sensor = new Sensor();
        sensor.MeasurementUpdated += (average) =>
        {
            Console.WriteLine($"Середнє значення вимірювань: {average}");
        };
        sensor.AddMeasurement(10.5);
        sensor.AddMeasurement(15.2);
        sensor.AddMeasurement(20.0);
        Console.ReadKey();
    }
}
