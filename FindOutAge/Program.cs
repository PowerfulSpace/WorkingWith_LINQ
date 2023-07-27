

var people = new List<Person>
{
    new Person ("Tom", 23),
    new Person ("Bob", 27)
};

var personel = from p in people
               select new
               {
                   FirstName = p.Name,
                   Year = DateTime.Now.Year - p.Age
               };

foreach (var p in personel)
    Console.WriteLine($"{p.FirstName} - {p.Year}");








Console.ReadLine();






record class Person(string Name, int Age);