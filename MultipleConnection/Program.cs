
Person magnus = new(FirstName: "Magnus", LastName: "Hedlund");
Person terry = new("Terry", "Adams");
Person charlotte = new("Charlotte", "Weiss");
Person arlene = new("Arlene", "Huff");
Person rui = new("Rui", "Raposo");
Person phyllis = new("Phyllis", "Harris");

List<Person> people = new() { magnus, terry, charlotte, arlene, rui, phyllis };

List<Cat> cats = new()
{
    new(Name: "Barley", Owner: terry),
    new("Boots", terry),
    new("Whiskers", charlotte),
    new("Blue Moon", rui),
    new("Daisy", magnus),
};

List<Dog> dogs = new()
{
    new(Name: "Four Wheel Drive", Owner: phyllis),
    new("Duke", magnus),
    new("Denim", terry),
    new("Wiley", charlotte),
    new("Snoopy", rui),
    new("Snickers", arlene),
};

//var query = people.Join(cats,
//        person => person,
//        cat => cat.Owner,
//        (person, cat) => new { person, cat })
//    .Join(dogs,
//        commonOwner => new { Owner = commonOwner.person, Letter = commonOwner.cat.Name.Substring(0, 1) },
//        dog => new { dog.Owner, Letter = dog.Name.Substring(0, 1) },
//        (commonOwner, dog) => new { CatName = commonOwner.cat.Name, DogName = dog.Name });

var query =
    from person in people
    join cat in cats on person equals cat.Owner
    join dog in dogs on new
    {
        Owner = person,
        Letter = cat.Name.Substring(0, 1)
    } equals new
    {
        dog.Owner,
        Letter = dog.Name.Substring(0, 1)
    }
    select new
    {
        CatName = cat.Name,
        DogName = dog.Name
    };

string result = "";
foreach (var obj in query)
{
    result += $"The cat \"{obj.CatName}\" shares a house, and the first letter of their name, with \"{obj.DogName}\".\r\n";
}
Console.Write(result);


Console.ReadLine();



record Person(string FirstName, string LastName);
record Pet(string Name, Person Owner);
record Employee(string FirstName, string LastName, int EmployeeID);
record Cat(string Name, Person Owner) : Pet(Name, Owner);
record Dog(string Name, Person Owner) : Pet(Name, Owner);