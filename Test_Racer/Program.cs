
//Вывести на консоль таблицу результатов (первые десять) в виде
//Например:
//Год Чемпион	Кубок конструкторов
//1978	Култхард	МакЛарен Мерседес 

var racers = Formula1.GetChampions();
var teams = Formula1.GetContructorChampions();

//var quary = teams.SelectMany(x => x.Years, (x, y) => new { Year = y, MyRacer = x.Name });
//var quary2 = racers.SelectMany(x => x.Years, (x, y) => new { Year = y, MyRacer = x.FirstName });

//---------------------------------------------------------------------------------------
//var quary3 = from x in racers
//             select new
//             {
//                 Name = x.LastName,
//                 Years = x.Years,
//                 Cars = x.Cars.Aggregate((first, next) => $"{first} {next}")
//             };

//foreach (var item in quary3)
//{
//    foreach (var item2 in item.Years)
//    {
//        Console.WriteLine("{0,-10} {1,-10} {2}", item2, item.Name, item.Cars);
//    }
//}
//---------------------------------------------------------------------------------------


var quary4 = from x in racers
             from y in x.Years
             group x by y into g
             select g;

foreach (var item in quary4)
{
    Console.WriteLine(item.Key);
    foreach (var item2 in item)
    {
        Console.WriteLine(item2);
    }
}




Console.ReadLine();






public static class Formula1
{
    private static List<Racer> racers;
    public static IList<Racer> GetChampions()
    {
        if (racers == null)
        {
            racers = new List<Racer>(40);
            racers.Add(new Racer("Nino", "Farina", "Italy", 33, 5,
                        new int[] { 1950 }, new string[] { "Alfa Romeo" }));
            racers.Add(new Racer("Alberto", "Ascari", "Italy", 32, 10,
                        new int[] { 1952, 1953 }, new string[] { "Ferrari" }));
            racers.Add(new Racer("Juan Manuel", "Fangio", "Argentina", 51, 24,
                        new int[] { 1951, 1954, 1955, 1956, 1957 },
                        new string[] { "Alfa Romeo", "Maserati", "Mercedes", "Ferrari" }));
            racers.Add(new Racer("Mike", "Hawthorn", "UK", 45, 3,
                        new int[] { 1958 }, new string[] { "Ferrari" }));
            racers.Add(new Racer("Phil", "Hill", "USA", 48, 3, new int[] { 1961 },
                        new string[] { "Ferrari" }));
            racers.Add(new Racer("John", "Surtees", "UK", 111, 6,
                        new int[] { 1964 }, new string[] { "Ferrari" }));
            racers.Add(new Racer("Jim", "Clark", "UK", 72, 25,
                        new int[] { 1963, 1965 }, new string[] { "Lotus" }));
            racers.Add(new Racer("Jack", "Brabham", "Australia", 125, 14,
                        new int[] { 1959, 1960, 1966 },
                        new string[] { "Cooper", "Brabham" }));
            racers.Add(new Racer("Denny", "Hulme", "New Zealand", 112, 8,
                        new int[] { 1967 }, new string[] { "Brabham" }));
            racers.Add(new Racer("Graham", "Hill", "UK", 176, 14,
                        new int[] { 1962, 1968 }, new string[] { "BRM", "Lotus" }));
            racers.Add(new Racer("Jochen", "Rindt", "Austria", 60, 6,
                        new int[] { 1970 }, new string[] { "Lotus" }));
            racers.Add(new Racer("Jackie", "Stewart", "UK", 99, 27,
                        new int[] { 1969, 1971, 1973 },
                        new string[] { "Matra", "Tyrrell" }));
        }
        return racers;
    }


    private static List<Team> teams;
    public static IList<Team> GetContructorChampions()
    {
        if (teams == null)
        {
            teams = new List<Team>()
                {
                    new Team("Vanwall", 1958),
                    new Team("Cooper", 1959, 1960),
                    new Team("Ferrari", 1961, 1964, 1975, 1976, 1977, 1979, 1982,
                            1983, 1999, 2000, 2001, 2002, 2003, 2004, 2007, 2008),
                    new Team("BRM", 1962),
                    new Team("Lotus", 1963, 1965, 1968, 1970, 1972, 1973, 1978),
                    new Team("Brabham", 1966, 1967),
                    new Team("Matra", 1969),
                    new Team("Tyrrell", 1971),
                    new Team("McLaren", 1974, 1984, 1985, 1988, 1989, 1990, 1991, 1998),
                    new Team("Williams", 1980, 1981, 1986, 1987, 1992, 1993, 1994, 1996,
                            1997),
                    new Team("Benetton", 1995),
                    new Team("Renault", 2005, 2006),
                    new Team("Brawn GP", 2009),
                    new Team("Red Bull Racing", 2010, 2011)
                };
        }
        return teams;
    }
}


public class Racer : IComparable<Racer>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Wins { get; set; }
    public string Country { get; set; }
    public int Starts { get; set; }
    public IEnumerable<string> Cars { get; private set; }
    public IEnumerable<int> Years { get; private set; }


    public Racer(string firstName, string lastName, string country, int starts, int wins)
        : this(firstName, lastName, country, starts, wins, null, null) { }

    public Racer(string firstName, string lastName, string country,
    int starts, int wins, IEnumerable<int> years, IEnumerable<string> cars)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Country = country;
        this.Starts = starts;
        this.Wins = wins;
        this.Years = new List<int>(years);
        this.Cars = new List<string>(cars);
    }

    public int CompareTo(Racer other)
    {
        if (other == null) return -1;
        return string.Compare(this.LastName, other.LastName);
    }
    public override string ToString()
    {
        return String.Format("{0} {1}, {2}; starts: {3}, wins: {4}",
                FirstName, LastName, Country, Starts, Wins);
    }
}

public class Team
{
    public Team(string name, params int[] years)
    {
        this.Name = name;
        this.Years = new List<int>(years);
    }
    public string Name { get; private set; }
    public IEnumerable<int> Years { get; private set; }
}