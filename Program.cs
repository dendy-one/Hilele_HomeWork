using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //масив чисел
                int[] num = new int[30];
                Random ran = new Random();

                //цикл створює рандомні числа від 0 до 101
                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = ran.Next(0, 101);
                }

                // коли виповнився нижній цикл, цей цикл вставляє мінімальну цифру і так ще 30 раз поки не дойде до кінця
                for (int i = 0; i < num.Length - 1; i++)
                {
                    //продивляється кожну цифру масиву і шукає мінімальну
                    for (int j = 0; j < num.Length - i - 1; j++)
                    {

                        if (num[j] > num[j + 1])
                        {

                            int temp = num[j];
                            num[j] = num[j + 1];
                            num[j + 1] = temp;
                        }
                    }
                }


                Console.WriteLine("просортерованые числа:");
                foreach (int number in num)
                {
                    Console.Write(number + " ");
                }
                Console.ReadKey();
            }

            catch (Exception) 
            {
                Console.WriteLine("ошибка выполнения сортировки");
                Console.ReadKey();
                
            }
        }
    }
}
