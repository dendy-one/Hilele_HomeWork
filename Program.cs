using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{

    enum PizzaType
    {
        Margherita = 1,
        Pepperoni,
        Hawaiian,
        Vegetarian
    }

    enum DrinkType
    {
        Cola = 5,
        Fanta,
        Pepsi
    }

    internal class Program

    {
        static void Main(string[] args)
        {
            //1
            //try
            //{
            //    Console.WriteLine("ведите первое число");
            //    var num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("ведите второе число");
            //    var num2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Ведите тип операции (+,-,*,/,%)");
            //    char mathOperation = Convert.ToChar(Console.ReadLine());
            //    Console.Clear();
            //    switch (mathOperation)
            //    {

            //        case '+':
            //            Console.WriteLine($"{num1}+{num2}={num1 + num2}");
            //            break;
            //        case '-':
            //            Console.WriteLine($"{num1}-{num2}={num1 - num2}");
            //            break;
            //        case '*':
            //            Console.WriteLine($"{num1}*{num2}={num1 * num2}");
            //            break;
            //        case '/':
            //            Console.WriteLine($"{num1}/{num2}={num1 / num2}");
            //            break;

            //        case '%':
            //            Console.WriteLine($"{num1}%{num2}={num1 % num2}");
            //            break;

            //        default:
            //            Console.WriteLine("Incorrect math action");
            //            break;
            //    }
            //    Console.WriteLine("Нажмите любую клавишу") ;
            //    Console.ReadKey();
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("не можна ділити на нуль");
            //    Console.ReadKey();
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("калькулятор не понимает что вы хотите");
            //    Console.ReadKey();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("калькулятор сам не понимает какая ошибка");
            //    Console.ReadKey();
            //}







            ////2








            //try
            //{
            //    Console.WriteLine("Добро пожаловать в пиццерию!");
            //    Console.WriteLine("Выберите пиццу (1-4):");

            //    int pizzaChoice = Convert.ToInt32(Console.ReadLine());
            //    if (pizzaChoice < 1 || pizzaChoice > 4)
            //    {
            //        Console.WriteLine("я же сказал что выбор от 1 до 4");
            //        Console.ReadKey();
            //        return;
                    
                    
            //    }
            //    PizzaType selectedPizza = (PizzaType)pizzaChoice;

            //    Console.WriteLine($"Вы выбрали {selectedPizza}. Сколько пиццы вам нужно?");

            //    int pizzaQuantity = Convert.ToInt32(Console.ReadLine());
            //    if (pizzaQuantity < 1)
            //    {
            //        Console.WriteLine("простите но я не могу вам дать ничего в руки");
            //        Console.ReadKey();


            //        return;
            //    }

            //    Console.WriteLine("Теперь выберите напиток (5-7):");
            //    int drinkChoice = Convert.ToInt32(Console.ReadLine());
            //    if (drinkChoice < 5 || drinkChoice > 7)
            //    {
            //        Console.WriteLine("я же сказал что выбор от 5 до 7");
            //        Console.ReadKey();


            //        return;
            //    }

            //    DrinkType selectedDrink = (DrinkType)drinkChoice;


            //    Console.WriteLine($"Вы выбрали {selectedDrink}. Сколько напитков вам нужно?");
            //    int drinkQuantity = Convert.ToInt32(Console.ReadLine());
            //    if (drinkQuantity < 1)
            //    {
            //        Console.WriteLine("как понимаю стакан  вам нада");
            //        Console.ReadKey();
            //        return;
            //    }
            //    double pizzaPrice = 10.0;
            //    double drinkPrice = 3.0;
            //    double totalPrice = (pizzaPrice * pizzaQuantity) + (drinkPrice * drinkQuantity);



            //    if (totalPrice > 50)
            //    {
            //        double discount = totalPrice * 0.2;
            //        totalPrice -= discount;
            //        Console.WriteLine($"Скидка 20%  к оплате принята, в итоге ${totalPrice}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Итого к оплате: ${totalPrice}");
            //    }





            //    int freePizzas = pizzaQuantity / 5;
            //    Console.WriteLine($" вот вам боннусные бесплатные  {freePizzas} пицци");

            //    Console.WriteLine("вот ваш заказ");
            //    Console.ReadKey();
            //}
            
            //catch (Exception ex) 
            //{
            //    Console.WriteLine("пожалуйста следуйте инструкциям", ex.Message );
            //    Console.ReadKey();
            //}

        }
    }
}
        
    





    

