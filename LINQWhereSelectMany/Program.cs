
var people = new List<Person>
{
    new Person ("Tom", 23, new List<string> {"english", "german"}),
    new Person ("Bob", 27, new List<string> {"english", "french" }),
    new Person ("Sam", 29, new List<string>  { "english", "spanish" }),
    new Person ("Alice", 24, new List<string> {"spanish", "german" })
};


var selectedPeople = people.SelectMany(u => u.Languages, (u, l) => new { Person = u, Lang = l })
                          .Where(u => u.Lang == "english" && u.Person.Age < 28)
                          .Select(u => u.Person);

foreach (var item in selectedPeople)
{
    Console.WriteLine(item.Name);
    foreach (var item2 in item.Languages)
    {
        Console.Write("- {0} ", item2);
    }
    Console.WriteLine();
}


Console.ReadLine();



record class Person(string Name, int Age, List<string> Languages);