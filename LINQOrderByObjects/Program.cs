



Person[] students = { new Person("Tom"), new Person("Bob"), new Person("Sam") };
Person[] employees = { new Person("Tom"), new Person("Bob"), new Person("Mike") };

// объединение последовательностей
var people = students.Union(employees);

foreach (Person person in people)
    Console.WriteLine(person.Name);
Console.ReadLine();

class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;

    public override bool Equals(object? obj)
    {
        if (obj is Person person) return Name == person.Name;
        return false;
    }
    public override int GetHashCode() => Name.GetHashCode();
}