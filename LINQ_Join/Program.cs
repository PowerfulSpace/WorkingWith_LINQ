
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

//var employees = people.Join(companies, // второй набор
//             p => p.Company, // свойство-селектор объекта из первого набора
//             c => c.Title, // свойство-селектор объекта из второго набора
//             (p, c) => new { Name = p.Name, Company = c.Title, Language = c.Language }); // результат


var employees = from p in people
                join c in companies on p.Company equals c.Title
                select new { Name = p.Name, Company = c.Title, Language = c.Language };

foreach (var emp in employees)
    Console.WriteLine($"{emp.Name} - {emp.Company} ({emp.Language})");


Console.ReadLine();


record class Person(string Name, string Company);
record class Company(string Title, string Language);