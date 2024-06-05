using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //#1
            //try
            //{
            //    Console.WriteLine("начало диапазона");
            //    int number1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("конец диапазона");
            //    int number2 = Convert.ToInt32(Console.ReadLine());

            //    if (number1 >=  number2) 
            //    {
            //        Console.WriteLine(" начало диапазона не может быть больше за конец");
            //        Console.ReadKey();
            //        return;

            //    }
            //    for (int i = number1; i <= number2; i++)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();

            //    for (int i = number2; i >= number1; i--)
            //    {



            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();

            //    for (int i = number1; i <= number2; i++)
            //    {
            //        if (i % 7 != 0)
            //        {
            //            continue;
            //        }
            //        Console.Write(i + " ");

            //    }
            //    Console.WriteLine();


            //    int num5 = 0;

            //    for (int i = number1; i <= number2; i++)
            //    {

            //        if (i % 5 == 0)
            //        {
            //            num5++;


            //        }
            //    }
            //    Console.WriteLine($"в данном диапозоне {num5} чисел кратные 5 ");
            //    Console.ReadKey();
            //}
            //catch(IndexOutOfRangeException)
            //{
            //    Console.WriteLine("числа вийшли з діапозона");
            //}
            //catch (Exception) 
            //{
            //    Console.WriteLine("перепрошую сталась помилка");
            //}




           //#2
//try
//{
//    Console.OutputEncoding = System.Text.Encoding.UTF8;
//    Console.WriteLine("Введіть перше число: ");
//    int a = int.Parse(Console.ReadLine());
//    Console.WriteLine("Введіть друге число: ");
//    int b = int.Parse(Console.ReadLine());

//    int sumEven = 0;
//    int sumOdd = 0;
//    int sumMultipleOf9 = 0;

//    for (int number = a; number <= b; number++)
//    {
//        if (number % 2 == 0)
//            sumEven += number;
//        else
//            sumOdd += number;

//        if (number % 9 == 0)
//            sumMultipleOf9 += number;
//    }

//    int countEven = (b - a + 1) / 2;
//    int countOdd = (b - a + 1) - countEven;
//    int countMultipleOf9 = (b - a + 1) / 9;

//    double averageEven = (double)sumEven / countEven;
//    double averageOdd = (double)sumOdd / countOdd;
//    double averageMultipleOf9 = (double)sumMultipleOf9 / countMultipleOf9;

//    Console.WriteLine($"Сума парних чисел: {sumEven}, середнє арифметичне: {averageEven}\nСума непарних чисел: {sumOdd}, середнє арифметичне:{averageOdd}");

//    Console.WriteLine($"Сума чисел, кратних 9: {sumMultipleOf9}, середнє арифметичне: {averageMultipleOf9}");
//    Console.ReadKey();
//}
//catch (Exception ex) 
//{  Console.WriteLine(ex.Message);
//    Console.ReadKey();
//}



        }
    }
}
