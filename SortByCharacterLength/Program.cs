


var companyNames = new[] {
    "Consolidated Messenger", "Alpine Ski House", "Southridge Video",
    "City Power & Light", "Coho Winery", "Wide World Importers",
    "Graphic Design Institute", "Adventure Works", "Humongous Insurance",
    "Woodgrove Bank", "Margie's Travel", "Northwind Traders",
    "Blue Yonder Airlines", "Trey Research", "The Phone Company",
    "Wingtip Toys", "Lucerne Publishing", "Fourth Coffee"
};

IQueryable<string> companyNamesSource = companyNames.AsQueryable();
var fixedQry = companyNames.OrderBy(x => x);

//Выбор первых символов слов, которые не повторяются
var length = 1;
var qry = companyNamesSource
    .Select(x => x.Substring(0, length))
    .Distinct();

Console.WriteLine(string.Join(",", qry));
Console.WriteLine();

length = 2;
Console.WriteLine(string.Join(",", qry));


//Сортировка по длине символов
qry = companyNamesSource;
if (qry != null)
{
    qry = qry.OrderBy(x => x.Length);
}
Console.WriteLine();
foreach (var item in qry)
{
    Console.WriteLine(item);
}


Console.ReadLine();

