
//Как подсчитать количество вхождений слова в строку (LINQ) (C#)

string text = @"Historically, the world of data and the world of objects" +
         @" have not been well integrated. Programmers work in C# or Visual Basic" +
         @" and also in SQL or XQuery. On the one side are concepts such as classes," +
         @" objects, fields, inheritance, and .NET APIs. On the other side" +
         @" are tables, columns, rows, nodes, and separate languages for dealing with" +
         @" them. Data types often require translation between the two worlds; there are" +
         @" different standard functions. Because the object world has no notion of query, a" +
         @" query can only be represented as a string without compile-time type checking or" +
         @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
         @" objects in memory is often tedious and error-prone.";


string searchTerm = "data";

string[] array = text.Split(new char[] { '.', ',', '!',' ','?',':' },StringSplitOptions.RemoveEmptyEntries);


var quary = from x in array
            where x.Equals(searchTerm, StringComparison.InvariantCultureIgnoreCase)
            select x;


Console.WriteLine($"Количество элементов : {searchTerm} : {quary.Count()}");
foreach (var item in quary)
{
    Console.Write(item + " ");
}



Console.ReadLine();




