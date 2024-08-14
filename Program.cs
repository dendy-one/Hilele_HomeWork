using System;

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    private double mileage;

    public int Age
    {
        get
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - Year;
        }
    }

    public double Mileage
    {
        get { return mileage; }
        private set { mileage = value; }
    }

    public Car(string brand, string model, int year, double mileage)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Mileage = mileage;
    }

    public void Drive(double distance)
    {
        if (distance > 0)
        {
            Mileage += distance;
            Console.WriteLine($"Пробіг автомобіля збільшено на {distance} км. Загальний пробіг: {Mileage} км.");
        }
        else
        {
            Console.WriteLine("Некоректне значення відстані. Пробіг не змінено.");
        }
    }

    ~Car()
    {
        Console.WriteLine($"Об'єкт автомобіля {Brand} {Model} видалено.");
    }
}

class ElectricCar : Car
{
    public double BatteryCapacity { get; set; }

    public ElectricCar(string brand, string model, int year, double mileage, double batteryCapacity)
        : base(brand, model, year, mileage)
    {
        BatteryCapacity = batteryCapacity;
    }

    public void Charge(double amount)
    {
        if (amount > 0)
        {
            BatteryCapacity += amount;
            Console.WriteLine($"Заряд батареї збільшено на {amount} кВт·год.");
        }
        else
        {
            Console.WriteLine("Некоректне значення заряду. Заряд батареї не змінено.");
        }
    }

    public new void Drive(double distance)
    {
        if (distance > 0)
        {
            base.Drive(distance);
            double energyConsumption = distance * 0.1;
            BatteryCapacity -= energyConsumption;

          
            if (BatteryCapacity < 0)
            {
                BatteryCapacity = 0;
            }

            Console.WriteLine($"Рівень заряду батареї після поїздки: {BatteryCapacity:F2} кВт·год.");
        }
        else
        {
            Console.WriteLine("Некоректне значення відстані. Пробіг не змінено.");
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //данні звичайного авто
            Console.WriteLine("Введіть інформацію про звичайний автомобіль:");
            Console.Write("Марка: ");
            string brand = Console.ReadLine();
            Console.Write("Модель: ");
            string model = Console.ReadLine();
            Console.Write("Рік випуску: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Пробіг (км): ");
            double mileage = double.Parse(Console.ReadLine());

            Car myCar = new Car(brand, model, year, mileage);

            Console.WriteLine($"\nМарка: {myCar.Brand}, Модель: {myCar.Model}, Рік: {myCar.Year}, Пробіг: {myCar.Mileage} км, Вік: {myCar.Age} років");

            //електро авто
            Console.WriteLine("\nВведіть інформацію про електромобіль:");
            Console.Write("Марка: ");
            string eBrand = Console.ReadLine();
            Console.Write("Модель: ");
            string eModel = Console.ReadLine();
            Console.Write("Рік випуску: ");
            int eYear = int.Parse(Console.ReadLine());
            Console.Write("Пробіг (км): ");
            double eMileage = double.Parse(Console.ReadLine());
            Console.Write("Ємність батареї (кВт·год): ");
            double batteryCapacity = double.Parse(Console.ReadLine());

            ElectricCar myElectricCar = new ElectricCar(eBrand, eModel, eYear, eMileage, batteryCapacity);

            Console.WriteLine($"\nМарка: {myElectricCar.Brand}, Модель: {myElectricCar.Model}, Рік: {myElectricCar.Year}, Пробіг: {myElectricCar.Mileage} км, Ємність батареї: {myElectricCar.BatteryCapacity} кВт·год");

            
            Console.Write("\nВведіть відстань для поїздки на звичайному автомобілі (км): ");
            double distance = double.Parse(Console.ReadLine());
            myCar.Drive(distance);

            Console.Write("\nВведіть відстань для поїздки на електромобілі (км): ");
            double eDistance = double.Parse(Console.ReadLine());
            myElectricCar.Drive(eDistance);

            Console.Write("\nВведіть кількість заряду для електромобіля (кВт·год): ");
            double chargeAmount = double.Parse(Console.ReadLine());
            myElectricCar.Charge(chargeAmount);

            
            Console.WriteLine($"\nПісля поїздки і зарядки:");
            Console.WriteLine($"Звичайний автомобіль - Пробіг: {myCar.Mileage} км, Вік: {myCar.Age} років");
            Console.WriteLine($"Електромобіль - Пробіг: {myElectricCar.Mileage} км, Ємність батареї: {myElectricCar.BatteryCapacity} кВт·год");

           
            myElectricCar = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка введення даних. Переконайтеся, що всі числові значення введені правильно.");
        }
    }
}
