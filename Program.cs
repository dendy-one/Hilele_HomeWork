using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        try
        {
            string homePhonePattern = @"^\d{7}$";
            Console.WriteLine("Ведіть свій домашній номер");
            string homePhoneNumber = Console.ReadLine();

            bool isHomePhoneValid = Regex.IsMatch(homePhoneNumber, homePhonePattern);

            Console.WriteLine($"Домашній номер телефону валідний: {isHomePhoneValid}");


            string mobilePhonePattern = @"^\+?\d{10,15}$";
            Console.WriteLine("Ведіть  номер телефону");
            string mobilePhoneNumber = Console.ReadLine();

            bool isMobilePhoneValid = Regex.IsMatch(mobilePhoneNumber, mobilePhonePattern);
            Console.WriteLine($"Мобільний номер телефону валідний: {isMobilePhoneValid}");


            string emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2}$";
            Console.WriteLine("Ведіть свій email адрес");
            string emailAddress = Console.ReadLine();

            bool isEmailValid = Regex.IsMatch(emailAddress, emailPattern);
            Console.WriteLine($"Email валідний: {isEmailValid}");


            string fullNamePattern = @"^[\p{L}]{2,20}\s[\p{L}]{2,20}\s[\p{L}]{2,20}$";
            Console.WriteLine("Ведіть своє ПІБ");

            string fullName = Console.ReadLine();

            bool isFullNameValid = Regex.IsMatch(fullName, fullNamePattern);
            Console.WriteLine($"ПІБ валідне: {isFullNameValid}");
            Console.ReadKey();
        }
        catch (Exception ex) 
        { Console.WriteLine(" Возникла ошибка пожалуйста соблюдайте инструкции"); }
    }
}
