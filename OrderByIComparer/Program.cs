
string[] people = new[] { "Kate", "Tom", "Sam", "Mike", "Alice" };
var sortedPeople = people.OrderBy(p => p, new CustomStringComparer());

foreach (var p in sortedPeople)
    Console.WriteLine(p);

Console.ReadLine();



// сравнение по длине строки
class CustomStringComparer : IComparer<String>
{
    public int Compare(string? x, string? y)
    {
        int xLength = x?.Length ?? 0; // если x равно null, то длина 0
        int yLength = y?.Length ?? 0;
        return xLength - yLength;
    }
}