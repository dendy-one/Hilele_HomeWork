using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork8
{
    internal class Program
    {
        static List<string> taskList = new List<string>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Оберіть дію:");
                Console.WriteLine("1. Додати завдання");
                Console.WriteLine("2. Змінити завдання");
                Console.WriteLine("3. Видалити завдання");
                Console.WriteLine("4. Переглянути завдання");
                Console.WriteLine("5. Вийти");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        ChangeTask();
                        break;
                    case 3:
                        RemoveTask();
                        break;
                    case 4:
                        ViewTasks();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Недійсний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Введіть завдання: ");
            string task = Console.ReadLine();
            taskList.Add(task);
            Console.WriteLine($"Завдання '{task}' додано до списку.");
        }

        static void ChangeTask()
        {
            Console.Write("Введіть індекс завдання, яке хочете змінити: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < taskList.Count)
            {
                Console.Write("Введіть нове завдання: ");
                string newTask = Console.ReadLine();
                taskList[index] = newTask;
                Console.WriteLine($"Завдання з індексом {index} змінено на '{newTask}'.");
            }
            else
            {
                Console.WriteLine("Недійсний індекс завдання.");
            }
        }

        static void RemoveTask()
        {
            Console.Write("Введіть індекс завдання, яке хочете видалити: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < taskList.Count)
            {
                taskList.RemoveAt(index);
                Console.WriteLine($"Завдання з індексом {index} видалено.");
            }
            else
            {
                Console.WriteLine("Недійсний індекс завдання.");
            }
        }

        static void ViewTasks()
        {
            Console.WriteLine("Список завдань:");
            for (int i = 0; i < taskList.Count; i++)
            {
                Console.WriteLine($"{i}. {taskList[i]}");
            }
        }
    }
        
    
}
