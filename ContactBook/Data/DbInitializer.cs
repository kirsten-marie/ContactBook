namespace ContactBook.Data;

public static class DbInitializer
{
    public static void Initalize(ContactBookContext context)
    {
        if (context.Contacts.Any() && context.ContactFrequencies.Any()) return;

            var accountContact = new ContactFrequency("Contact only about account information");
            var marketingContact = new ContactFrequency("OK to contact with marketing information");
            var thirdPartyMarketing = new ContactFrequency("OK to contact with third-party marketing information");

            var frequencies = new ContactFrequency[]
            {
                accountContact,
                marketingContact,
                thirdPartyMarketing
            };

            context.ContactFrequencies.AddRange(frequencies);

            var contacts = new Contact[]
            {
                new Contact{FirstName="Yelena",LastName="Belova",EmailAddress="yelenabelova@example.com",PhoneNumber="5553214567",ContactFrequency=accountContact,
                            Address = new Address{Street="639 Willow Way",City="Knoxville",State="TN",ZipCode="37919"}},
                new Contact{FirstName="Thor",LastName="Odinson",EmailAddress="thorodinson@example.com",PhoneNumber="5551112234",ContactFrequency=accountContact,
                            Address = new Address{Street="51 Prairieview Pass",City="Dallas",State="TX",ZipCode="75277"}},
                new Contact{FirstName="Steve",LastName="Rogers",EmailAddress="captainamerica@example.com",PhoneNumber="5553214568",ContactFrequency=marketingContact,
                            Address = new Address{Street="4 Lyons Place",City="Hartford",State="CT",ZipCode="06105"}},
                new Contact{FirstName="Clint",LastName="Barton",EmailAddress="hawkeye@example.com",PhoneNumber="5554561122", ContactFrequency=thirdPartyMarketing,
                            Address = new Address{Street="1 Menomonie Trail",City="New Orleans",State="LA",ZipCode="70124"}},
                new Contact{FirstName="Peter",LastName="Quill",EmailAddress="starlord@example.com",PhoneNumber="5554561128", ContactFrequency=thirdPartyMarketing,
                            Address = new Address{Street="87056 Carberry Circle",City="Arlington",State="VA",ZipCode="22205"}},
                new Contact{FirstName="Carol",LastName="Danvers",EmailAddress="captainmarvel@example.com",PhoneNumber="5558741234",ContactFrequency=accountContact,
                            Address = new Address{Street="7481 Hallows Drive",City="South Bend",State="IN",ZipCode="46634"}},
                new Contact{FirstName="Peter",LastName="Parker",EmailAddress="spiderman@example.com",PhoneNumber="5559876543", ContactFrequency=marketingContact,
                            Address = new Address{Street="1562 North Lane",City="Cleveland",State="OH",ZipCode="44177"}},
                new Contact{FirstName="Kate",LastName="Bishop",EmailAddress="kbishop@example.com",PhoneNumber="5552981648", ContactFrequency=marketingContact,
                            Address = new Address{Street="01153 Farmco Crossing",City="Tacoma",State="WA",ZipCode="98447"}},
                new Contact{FirstName="Hope",LastName="Pym",EmailAddress="hopepym@example.com",PhoneNumber="5558195452", ContactFrequency=thirdPartyMarketing,
                            Address = new Address{Street="2476 Sauthoff Crossing",City="Fort Worth",State="TX",ZipCode="76121"}},
                new Contact{FirstName="Bruce",LastName="Banner",EmailAddress="hulk@example.com",PhoneNumber="5556153824", ContactFrequency=thirdPartyMarketing,
                            Address = new Address{Street="10 Cody Avenue",City="Fresno",State="CA",ZipCode="93794"}}     
            };

            context.Contacts.AddRange(contacts);

            context.SaveChanges();
    }

}