



string[] fileA = File.ReadAllLines(@"D:\Testing\Test.txt");
string[] fileB = File.ReadAllLines(@"D:\Testing\Test2.txt");

var concatQuery = fileA.Concat(fileB).OrderBy(x => x);
OutputQueryResults(concatQuery, "Простая конкатенация и сортировка. Дубликаты сохраняются:");

var unionQuery = fileA.Union(fileB).OrderBy(x => x);
OutputQueryResults(unionQuery, "Союз удаляет повторяющиеся имена:");

var intersectQuary = fileA.Intersect(fileB).OrderBy(x => x);
OutputQueryResults(unionQuery, "Слияние на основе пересечения:");


string nameMatch = "Garcia";
var tempQuery1 =
                from name in fileA
                let n = name.Split(',')
                where n[0] == nameMatch
                select name;
var tempQuery2 =
    from name2 in fileB
    let n2 = name2.Split(',')
    where n2[0] == nameMatch
    select name2;

var nameMatchQuery =
               tempQuery1.Concat(tempQuery2).OrderBy(s => s);
OutputQueryResults(nameMatchQuery, $"Concat на основе частичного совпадения имени \"{nameMatch}\":");



File.WriteAllLines(@"D:\Testing\Test3.txt", nameMatchQuery);


Console.ReadLine();


static void OutputQueryResults(IEnumerable<string> query, string message)
{
    Console.WriteLine(System.Environment.NewLine + message);
    foreach (string item in query)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("{0} total names in list", query.Count());
}