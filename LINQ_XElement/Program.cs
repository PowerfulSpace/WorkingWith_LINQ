



using System.Xml.Linq;

Person magnus = new(FirstName: "Magnus", LastName: "Hedlund");
Person terry = new("Terry", "Adams");
Person charlotte = new("Charlotte", "Weiss");
Person arlene = new("Arlene", "Huff");

List<Person> people = new() { magnus, terry, charlotte, arlene };

List<Pet> pets = new()
{
    new(Name: "Barley", Owner: terry),
    new("Boots", terry),
    new("Whiskers", charlotte),
    new("Blue Moon", terry),
    new("Daisy", magnus),
};

XElement ownersAndPets = new("PetOwners",
    from person in people
    join pet in pets on person equals pet.Owner into gj
    select new XElement("Person",
        new XAttribute("FirstName", person.FirstName),
        new XAttribute("LastName", person.LastName),
        from subpet in gj
        select new XElement("Pet", subpet.Name)
    )
);

Console.WriteLine(ownersAndPets);



Console.ReadLine();



record Person(string FirstName, string LastName);
record Pet(string Name, Person Owner);
record Employee(string FirstName, string LastName, int EmployeeID);
record Cat(string Name, Person Owner) : Pet(Name, Owner);
record Dog(string Name, Person Owner) : Pet(Name, Owner);