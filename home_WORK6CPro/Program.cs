using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
      

        ContactsManager contactsManager = new ContactsManager();
        StudentsManager studentsManager = new StudentsManager();
        CustomerQueue customerQueue = new CustomerQueue();
        LibraryCatalog libraryCatalog = new LibraryCatalog();

        // Додавання контактів
        contactsManager.AddContact("John", "123-456-7890");
        contactsManager.AddContact("Alice", "987-654-3210");

        // Додавання студентів
        studentsManager.AddStudent("Alice");
        studentsManager.AddStudent("Bob");

        // Додавання покупців до черги
        customerQueue.AddCustomer("Charlie");

        // Додавання книг до каталогу
        libraryCatalog.AddBook("B123", "Harry Potter");
        libraryCatalog.AddBook("C456", "Lord of the Rings");

        // Виведення результатів
        contactsManager.DisplayContacts();
        studentsManager.DisplayStudentCount();
        Console.WriteLine($"Queue length: {customerQueue.GetQueueLength()}");
        libraryCatalog.DisplayBooks();
    }
}
