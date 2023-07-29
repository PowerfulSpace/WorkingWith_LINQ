
Person[] people =
{
    new Person("Tom", "Microsoft"), new Person("Sam", "Google"),
    new Person("Bob", "JetBrains"), new Person("Mike", "Microsoft"),
};
Company[] companies =
{
    new Company("Microsoft", "C#"),
    new Company("Google", "Go"),
    new Company("Oracle", "Java")
};
var personnel = companies.GroupJoin(people, // второй набор
             c => c.Title, // свойство-селектор объекта из первого набора
             p => p.Company, // свойство-селектор объекта из второго набора
             (c, employees) => new   // результат
             {
                 Title = c.Title,
                 Employees = employees
             });

foreach (var company in personnel)
{
    Console.WriteLine(company.Title);
    foreach (var emp in company.Employees)
    {
        Console.WriteLine(emp.Name);
    }
    Console.WriteLine();
}

Console.ReadLine();


record class Person(string Name, string Company);
record class Company(string Title, string Language);