





var companies = new List<Company>
{
    new Company("Microsoft", new List<Person> {new Person("Tom"), new Person("Bob")}),
    new Company("Google", new List<Person> {new Person("Sam"), new Person("Mike")}),
};
var employees = companies.SelectMany(c => c.Staff);

foreach (var emp in employees)
    Console.WriteLine($"{emp.Name}");



Console.ReadLine();

record class Company(string Name, List<Person> Staff);
record class Person(string Name);

