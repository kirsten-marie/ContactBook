namespace ContactBook.Data;

public static class DbInitializer
{
    public static void Initalize(ContactBookContext context)
    {
        InitializeStates(context);

        var choice1 = new Frequency("Contact only about account information");
        var choice2= new Frequency("OK to contact with marketing information");
        var choice3 = new Frequency("OK to contact with third-party marketing information");

        var frequencies = new Frequency[] {choice1,choice2,choice3};

        context.FrequencyChoices.AddRange(frequencies);
        context.SaveChanges();
        
            var contacts = new Contact[]
            {
                new Contact("Yelena", "Belova")
                {
                    EmailAddress="yelenabelova@example.com",
                    PhoneNumber="5553214567",
                    ContactFrequency=choice1,
                    Address = new Address
                    {
                        Street="10 Cody Avenue",
                        City="Fresno",
                        State=context.States.Find("CA"), 
                        ZipCode="93794"
                    }
                },
                new Contact("Thor","Odinson")
                {
                    EmailAddress="thorodinson@example.com",
                    PhoneNumber="5551112234",
                    ContactFrequency=choice1, 
                    Address = new Address
                    {
                        Street="793 Ridgeway Plaza",
                        City="Tulsa",
                        State=context.States.Find("OK"),
                        ZipCode="74184"
                    }
                },
                new Contact("Steve","Rogers")
                {
                    EmailAddress="captainamerica@example.com",
                    PhoneNumber="5553214568",
                    ContactFrequency=choice2,
                    Address =  new Address
                    {
                        Street="01153 Farmco Crossing",
                        City="Tacoma",
                        State=context.States.Find("WA"),
                        ZipCode="98447"
                    }
                },
                new Contact("Clint","Barton")
                {
                    EmailAddress="hawkeye@example.com",
                    PhoneNumber="5554561122", 
                    ContactFrequency=choice3,
                    Address =  new Address
                    {
                        Street="1562 North Lane",
                        City="Cleveland",
                        State=context.States.Find("OH"),
                        ZipCode="44177"
                    }
                },
                new Contact("Peter","Quill")
                {
                    EmailAddress="starlord@example.com",
                    PhoneNumber="5554561128", 
                    ContactFrequency=choice3,
                    Address = new Address
                    {
                        Street="7481 Hallows Drive",
                        City="South Bend",
                        State=context.States.Find("IN"),
                        ZipCode="46634"
                    }
                },
                new Contact("Carol","Danvers")
                { 
                    EmailAddress="captainmarvel@example.com",
                    PhoneNumber="5558741234",
                    ContactFrequency=choice1,
                    Address = new Address
                    {
                        Street="87056 Carberry Circle",
                        City="Arlington",
                        State=context.States.Find("VA"),
                        ZipCode="22205"
                    }
                },
                new Contact("Peter","Parker")
                { 
                    EmailAddress="spiderman@example.com",
                    PhoneNumber="5559876543", 
                    ContactFrequency=choice2,
                    Address = new Address
                    {
                        Street="1 Menomonie Trail",
                        City="New Orleans",
                        State=context.States.Find("LA"),
                        ZipCode="70124"
                    } 
                },
                new Contact("Kate","Bishop")
                { 
                    EmailAddress="kbishop@example.com",
                    PhoneNumber="5552981648", 
                    ContactFrequency=choice2,
                    Address = new Address
                    {
                        Street="4 Lyons Place",
                        City="Hartford",
                        State=context.States.Find("CT"),
                        ZipCode="06105"
                    }
                },
                new Contact("Hope","Pym")
                { 
                    EmailAddress="hopepym@example.com",
                    PhoneNumber="5558195452", 
                    ContactFrequency=choice3,
                    Address = new Address
                    {
                        Street="51 Prairieview Pass",
                        City="Dallas",
                        State=context.States.Find("TX"),
                        ZipCode="75277"
                    }
                },
                new Contact("Bruce","Banner")
                { 
                    EmailAddress="hulk@example.com",
                    PhoneNumber="5556153824", 
                    ContactFrequency=choice3,
                    Address =  new Address
                    {
                        Street="639 Willow Way",
                        City="Knoxville",
                        State=context.States.Find("TN"),
                        ZipCode="37919"
                    }
                }     
            };

            context.Contacts.AddRange(contacts);

            context.SaveChanges();
    }

    private static void InitializeStates(ContactBookContext context)
    {
        if(context.States.Any()) return;

        var states= new State[]
        {
            new State("AL","Alabama"),
            new State("AK","Alaska"),
            new State("AZ","Arizona"),
            new State("AR","Arkansas"),
            new State("CA","California"),
            new State("CO","Colorado"),
            new State("CT","Connecticut"),
            new State("DE","Delaware"),
            new State("DC","District of Columbia"),
            new State("FL","Florida"),
            new State("GA","Georgia"),
            new State("HI","Hawaii"),
            new State("ID","Idaho"),
            new State("IL","Illinois"),
            new State("IN","Indiana"),
            new State("IA","Iowa"),
            new State("KS","Kansas"),
            new State("KY","Kentucky"),
            new State("LA","Louisiana"),
            new State("ME","Maine"),
            new State("MD","Maryland"),
            new State("MA","Massachusetts"),
            new State("MI","Michigan"),
            new State("MN","Minnesota"),
            new State("MS","Mississippi"),
            new State("MO","Missouri"),
            new State("MT","Montana"),
            new State("NE","Nebraska"),
            new State("NV","Nevada"),
            new State("NH","New Hampshire"),
            new State("NJ","New Jersey"),
            new State("NM","New Mexico"),
            new State("NY","New York"),
            new State("NC","North Carolina"),
            new State("ND","North Dakota"),
            new State("OH","Ohio"),
            new State("OK","Oklahoma"),
            new State("OR","Oregon"),
            new State("PA","Pennsylvania"),
            new State("RI","Rhode Island"),
            new State("SC","South Carolina"),
            new State("SD","South Dakota"),
            new State("TN","Tennessee"),
            new State("TX","Texas"),
            new State("UT","Utah"),
            new State("VT","Vermont"),
            new State("VA","Virginia"),
            new State("WA","Washington"),
            new State("WV","Wisconsin"),
            new State("WY","Wyoming")
        };

        context.States.AddRange(states);
        context.SaveChanges();
    }

}