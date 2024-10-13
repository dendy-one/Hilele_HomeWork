using System.Collections;

class LibraryCatalog
{
    private Hashtable library = new Hashtable();

    public void AddBook(string code, string title)
    {
        library.Add(code, title);
    }

    public bool RemoveBook(string code)
    {
        if (library.ContainsKey(code))
        {
            library.Remove(code);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool TryGetBookTitle(string code, out string title)
    {
        title = library[code] as string;
        return title != null;
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Library books:");
        foreach (DictionaryEntry book in library)
        {
            Console.WriteLine($"{book.Key}: {book.Value}");
        }
    }
}
