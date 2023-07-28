
var people = new List<Person>
{
    new Person("Tom", 37),
    new Person("Sam", 28),
    new Person("Tom", 22),
    new Person("Bob", 41),
};
// с помощью оператора orderby
var sortedPeople1 = from p in people
                    orderby p.Name, p.Age
                    select p;

foreach (var p in sortedPeople1)
    Console.WriteLine($"{p.Name} - {p.Age}");

//С помощи метода расширения
var sortedPeople2 = people.OrderBy(p => p.Name).ThenByDescending(p => p.Age);

Console.ReadLine();



record class Person(string Name, int Age);