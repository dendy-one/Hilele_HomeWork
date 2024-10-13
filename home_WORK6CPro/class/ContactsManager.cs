class ContactsManager
{
    private Dictionary<string, string> contacts = new Dictionary<string, string>();

    public void AddContact(string name, string phoneNumber)
    {
        contacts[name] = phoneNumber;
    }

    public bool RemoveContact(string name)
    {
        return contacts.Remove(name);
    }

    public bool TryGetPhoneNumber(string name, out string phoneNumber)
    {
        return contacts.TryGetValue(name, out phoneNumber);
    }

    public void DisplayContacts()
    {
        Console.WriteLine("Contacts:");
        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.Key}: {contact.Value}");
        }
    }
}
