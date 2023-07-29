

string[] people = { "tom", "Tim", "bOb", "Sam" };

// проверяем, есть ли строка Tom
bool hasTom = people.Contains("Tom", new CustomStringComparer());     // true
Console.WriteLine(hasTom);

// проверяем, есть ли строка Bob
bool hasMike = people.Contains("Bob", new CustomStringComparer());     // true
Console.WriteLine(hasMike);

Console.ReadLine();



class CustomStringComparer : IEqualityComparer<string>
{
    public bool Equals(string? x, string? y)
    {
        if (x is null || y is null) return false;
        return x.ToLower() == y.ToLower();

    }

    public int GetHashCode(string obj) => obj.ToLower().GetHashCode();
}
