
Person magnus = new(FirstName: "Magnus", LastName: "Hedlund");
Person terry = new("Terry", "Adams");
Person charlotte = new("Charlotte", "Weiss");
Person arlene = new("Arlene", "Huff");
Person rui = new("Rui", "Raposo");

List<Person> people = new() { magnus, terry, charlotte, arlene, rui };

List<Pet> pets = new()
{
    new(Name: "Barley", Owner: terry),
    new("Boots", terry),
    new("Whiskers", charlotte),
    new("Blue Moon", rui),
    new("Daisy", magnus),
};

//var query =
//    people.Join(pets,
//                person => person,
//                pet => pet.Owner,
//                (person, pet) =>
//                    new { OwnerName = person.FirstName, PetName = pet.Name });

var query =
    from person in people
    join pet in pets on person equals pet.Owner
    select new
    {
        OwnerName = person.FirstName,
        PetName = pet.Name
    };


string result = "";

foreach (var ownerAndPet in query)
{
    result += $"\"{ownerAndPet.PetName}\" is owned by {ownerAndPet.OwnerName}\r\n";
}

Console.Write(result);

Console.ReadLine();



record Person(string FirstName, string LastName);
record Pet(string Name, Person Owner);
record Employee(string FirstName, string LastName, int EmployeeID);
record Cat(string Name, Person Owner) : Pet(Name, Owner);
record Dog(string Name, Person Owner) : Pet(Name, Owner);