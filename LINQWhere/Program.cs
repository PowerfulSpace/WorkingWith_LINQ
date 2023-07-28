
var people = new List<Person>
{
    new Person ("Tom", 23, new List<string> {"english", "german"}),
    new Person ("Bob", 27, new List<string> {"english", "french" }),
    new Person ("Sam", 29, new List<string>  { "english", "spanish" }),
    new Person ("Alice", 24, new List<string> {"spanish", "german" })
};


var selectedPeople = from person in people
                     from lang in person.Languages
                     where person.Age < 28
                     where lang == "english"
                     select person;

foreach (var item in selectedPeople)
{
    Console.WriteLine(item.Name + " " + item.Age);
    foreach (var item2 in item.Languages)
    {
        Console.WriteLine(item2);
    }
    Console.WriteLine();
}


Console.ReadLine();



record class Person(string Name, int Age, List<string> Languages);