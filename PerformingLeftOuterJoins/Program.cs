﻿



Person magnus = new("Magnus", "Hedlund");
Person terry = new("Terry", "Adams");
Person charlotte = new("Charlotte", "Weiss");
Person arlene = new("Arlene", "Huff");

Pet barley = new("Barley", terry);
Pet boots = new("Boots", terry);
Pet whiskers = new("Whiskers", charlotte);
Pet bluemoon = new("Blue Moon", terry);
Pet daisy = new("Daisy", magnus);

// Create two lists.
List<Person> people = new() { magnus, terry, charlotte, arlene };
List<Pet> pets = new() { barley, boots, whiskers, bluemoon, daisy };

var query =
    from person in people
    join pet in pets on person equals pet.Owner into gj
    from subpet in gj.DefaultIfEmpty()
    select new
    {
        person.FirstName,
        PetName = subpet?.Name ?? string.Empty
    };

foreach (var v in query)
{
    Console.WriteLine($"{v.FirstName + ":",-15}{v.PetName}");
}



Console.ReadLine();



record Person(string FirstName, string LastName);
record Pet(string Name, Person Owner);
record Employee(string FirstName, string LastName, int EmployeeID);
record Cat(string Name, Person Owner) : Pet(Name, Owner);
record Dog(string Name, Person Owner) : Pet(Name, Owner);