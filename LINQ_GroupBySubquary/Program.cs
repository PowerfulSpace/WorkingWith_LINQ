
Person[] people =
{
    new Person("Tom", "Microsoft"), new Person("Sam", "Google"),
    new Person("Bob", "JetBrains"), new Person("Mike", "Microsoft"),
    new Person("Kate", "JetBrains"), new Person("Alice", "Microsoft"),
};
var companies = from person in people
                group person by person.Company into g
                select new
                {
                    Name = g.Key,
                    Count = g.Count(),
                    Employees = from p in g select p
                };

foreach (var company in companies)
{
    Console.WriteLine($"{company.Name} : {company.Count}");
    foreach (var employee in company.Employees)
    {
        Console.WriteLine(employee.Name);
    }
    Console.WriteLine(); // для разделения компаний
}



//var companies = people
//                    .GroupBy(p => p.Company)
//                    .Select(g => new
//                    {
//                        Name = g.Key,
//                        Count = g.Count(),
//                        Employees = g.Select(p => p)
//                    });


Console.ReadLine();


record class Person(string Name, string Company);