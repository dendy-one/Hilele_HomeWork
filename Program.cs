using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work6
{
    internal class Program
    {
        //1
        //public static double CalculaterPower(double baseNumber, int exponent)
        //{
        //    return Math.Pow(baseNumber, exponent);
        //}

        //public static void Main()
        //{
        //    try
        //    {
        //        Console.OutputEncoding = Encoding.UTF8;

        //        Console.WriteLine("Ведіть основу ступеня");
        //        double baseNumber = Convert.ToDouble(Console.ReadLine());
        //        Console.WriteLine("Ведіть показник ступення ");
        //        int exponent = Convert.ToInt32(Console.ReadLine());

        //        double result = CalculaterPower(baseNumber, exponent);
        //        Console.WriteLine($"Результат: {result}");
        //        Console.ReadKey();
        //    }
        //    catch (Exception) 
        //    {
        //        Console.WriteLine("прошу делать всё по инструкции");
        //    } 



        //}






        //2
        //public static int SumInRange(int start, int end)
        //{
        //    int sum = 0;
        //    for (int i = start; i <= end; i++)
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}

        //public static void Main()
        //{
        //    try
        //    {
        //       Console.OutputEncoding = Encoding.UTF8;

        //        Console.Write("Введіть початок діапазону: ");
        //        int start = int.Parse(Console.ReadLine());

        //        Console.Write("Введіть кінець діапазону: ");
        //        int end = int.Parse(Console.ReadLine());

        //        int result = SumInRange(start, end);
        //        Console.WriteLine($"Сума чисел від {start} до {end}: {result}");
        //        Console.ReadKey();
        //    } catch(Exception) { Console.WriteLine("Please not do this again"); }

        //}




        //3

        //        public static bool IsPerfectNumber(int number)
        //        {
        //            int sumOfDivisors = 0;
        //            for (int i = 1; i < number; i++)
        //            {
        //                if (number % i == 0)
        //                {
        //                    sumOfDivisors += i;
        //                }
        //            }
        //            return sumOfDivisors == number;
        //        }

        //        public static void Main()

        //        {
        //            try
        //            {
        //               Console.OutputEncoding = Encoding.UTF8;


        //                int start = Convert.ToInt32(Console.ReadLine());
        //        int end = Convert.ToInt32(Console.ReadLine());
        //                for (int num = start; num <= end; num++)
        //                {
        //                    if (IsPerfectNumber(num))
        //                    {
        //                        Console.WriteLine($"Досконале число: {num}");
        //                    }
        //}
        //                   Console.ReadKey();
        //            } 
        //            catch(Exception) 
        //            {

        //               Console.WriteLine("please not do this again ");
        //               Console.ReadKey();

        //            }
        //        }


        //4
        //public static void DisplayCard(string[] cards, int cardIndex)
        //{
        //    if (cardIndex >= 0 && cardIndex < cards.Length)
        //    {
        //        Console.WriteLine($"Гральна карта #{cardIndex+1}: {cards[cardIndex]}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Неправильний індекс карти.");
        //    }
        //}

        //public static void Main()
        //{
        //    try
        //    {
        //        Console.OutputEncoding = Encoding.UTF8;

        //        string[] deckOfCards = { "Пиковая 6", "Чирвовий Туз", "Бубновий Король" };
        //        Console.WriteLine("Ведите цифру от 0 до 2");
        //        int cardIndexToDisplay = Convert.ToInt32(Console.ReadLine());
        //        DisplayCard(deckOfCards, cardIndexToDisplay);
        //        Console.ReadKey();
        //    }
        //    catch(Exception) { Console.WriteLine("пожалуйста ведите цифры в диапозоне");
        //        Console.ReadKey();
        //    }
        //}





        //5
        public static bool IsHappyNumber(int number)
        {
         
            int digit1 = number / 100000;
            int digit2 = (number / 10000) % 10;
            int digit3 = (number / 1000) % 10;
            int digit4 = (number / 100) % 10;
            int digit5 = (number / 10) % 10;
            int digit6 = number % 10;
            int sumFirstThreeDigits = digit1 + digit2 + digit3;
            int sumLastThreeDigits = digit4 + digit5 + digit6;

            return sumFirstThreeDigits == sumLastThreeDigits;
        }

        public static void Main()
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Ведіть шести значне число");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                bool isHappy = IsHappyNumber(inputNumber);
                Console.WriteLine($"Число {inputNumber} є щасливим: {isHappy}");
                Console.ReadKey();
            }
            catch(Exception) 
            {
                Console.WriteLine("будь ласка водьт тільки одне  6 значне число");
            }
        }
    }
}
