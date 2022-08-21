namespace ContactBook.Data;

public static class DbInitializer
{
    public static void Initalize(ContactBookContext context)
    {
            if (context.Contacts.Any() && context.Addresses.Any() && context.ContactFrequencies.Any()) return;

            var frequencies = new List<ContactFrequency>{
                new ContactFrequency("Contact only about account information"),
                new ContactFrequency("OK to contact with marketing information"),
                new ContactFrequency("OK to contact with third-party marketing information")
            };

            context.ContactFrequencies.AddRange(frequencies);

            

    }
}