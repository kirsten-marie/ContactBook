namespace ContactBook.Data;

public static class DbInitializer
{
    public static void Initalize(ContactBookContext context)
    {
        InitializeStates(context);

        InitializeFrequencies(context);
        
            var contacts = new Contact[]
            {
                new Contact("Yelena", "Belova")
                {
                    EmailAddress="yelenabelova@example.com",
                    PhoneNumber="5553214567",
                    ContactFrequency=context.FrequencyChoices.Find(1),
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
                    ContactFrequency=context.FrequencyChoices.Find(1), 
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
                    ContactFrequency=context.FrequencyChoices.Find(2),
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
                    ContactFrequency=context.FrequencyChoices.Find(3),
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
                    ContactFrequency=context.FrequencyChoices.Find(3),
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
                    ContactFrequency=context.FrequencyChoices.Find(1),
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
                    ContactFrequency=context.FrequencyChoices.Find(2),
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
                    ContactFrequency=context.FrequencyChoices.Find(2),
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
                    ContactFrequency=context.FrequencyChoices.Find(3),
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
                    ContactFrequency=context.FrequencyChoices.Find(3),
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

    private static void InitializeFrequencies(ContactBookContext context)
    {
        if (context.FrequencyChoices.Any()) return;

        var frequencies = new Frequency[] 
        {
            new Frequency{FrequencyId = 1, Description = "Contact only about account information"},
            new Frequency{FrequencyId = 2, Description = "OK to contact with marketing information"},
            new Frequency{FrequencyId = 3, Description= "OK to contact with third-party marketing information"},
        };

        context.FrequencyChoices.AddRange(frequencies);
        context.SaveChanges();
    }

   private static void InitializeStates(ContactBookContext context)
    {
        if (context.States.Any()) return;

        var states = new State[]
        {
            new State{Abbreviation="AL",Name="Alabama"},
            new State{Abbreviation="AK",Name="Alaska"},
            new State{Abbreviation="AZ",Name="Arizona"},
            new State{Abbreviation="AR",Name="Arkansas"},
            new State{Abbreviation="CA",Name="California"},
            new State{Abbreviation="CO",Name="Colorado"},
            new State{Abbreviation="CT",Name="Connecticut"},
            new State{Abbreviation="DE",Name="Delaware"},
            new State{Abbreviation="DC",Name="District of Columbia"},
            new State{Abbreviation="FL",Name="Florida"},
            new State{Abbreviation="GA",Name="Georgia"},
            new State{Abbreviation="HI",Name="Hawaii"},
            new State{Abbreviation="ID",Name="Idaho"},
            new State{Abbreviation="IL",Name="Illinois"},
            new State{Abbreviation="IN",Name="Indiana"},
            new State{Abbreviation="IA",Name="Iowa"},
            new State{Abbreviation="KS",Name="Kansas"},
            new State{Abbreviation="KY",Name="Kentucky"},
            new State{Abbreviation="LA",Name="Louisiana"},
            new State{Abbreviation="ME",Name="Maine"},
            new State{Abbreviation="MD",Name="Maryland"},
            new State{Abbreviation="MA",Name="Massachusetts"},
            new State{Abbreviation="MI",Name="Michigan"},
            new State{Abbreviation="MN",Name="Minnesota"},
            new State{Abbreviation="MS",Name="Mississippi"},
            new State{Abbreviation="MO",Name="Missouri"},
            new State{Abbreviation="MT",Name="Montana"},
            new State{Abbreviation="NE",Name="Nebraska"},
            new State{Abbreviation="NV",Name="Nevada"},
            new State{Abbreviation="NH",Name="New Hampshire"},
            new State{Abbreviation="NJ",Name="New Jersey"},
            new State{Abbreviation="NM",Name="New Mexico"},
            new State{Abbreviation="NY",Name="New York"},
            new State{Abbreviation="NC",Name="North Carolina"},
            new State{Abbreviation="ND",Name="North Dakota"},
            new State{Abbreviation="OH",Name="Ohio"},
            new State{Abbreviation="OK",Name="Oklahoma"},
            new State{Abbreviation="OR",Name="Oregon"},
            new State{Abbreviation="PA",Name="Pennsylvania"},
            new State{Abbreviation="RI",Name="Rhode Island"},
            new State{Abbreviation="SC",Name="South Carolina"},
            new State{Abbreviation="SD",Name="South Dakota"},
            new State{Abbreviation="TN",Name="Tennessee"},
            new State{Abbreviation="TX",Name="Texas"},
            new State{Abbreviation="UT",Name="Utah"},
            new State{Abbreviation="VT",Name="Vermont"},
            new State{Abbreviation="VA",Name="Virginia"},
            new State{Abbreviation="WA",Name="Washington"},
            new State{Abbreviation="WV",Name="Wisconsin"},
            new State{Abbreviation="WY",Name="Wyoming"}
        };

        context.States.AddRange(states);
        context.SaveChanges();
    }

}