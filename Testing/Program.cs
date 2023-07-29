

string[] people = { "Tom", "Sam", "Bob" };

var selectedPeople = people.Where(s => s.Length == 3).OrderBy(s => s);

people[2] = "Mike";
// выполнение LINQ-запроса
foreach (string s in selectedPeople)
    Console.WriteLine(s);
Console.ReadLine();



