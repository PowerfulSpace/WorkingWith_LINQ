
//Стоит учитывать, что для коллекций ссылочных типов FirstOrDefault возвращает значение типа T?
//(в примере выше - string?), то есть значение, которое может быть равно null,
//а значение по умолчанию - null. Для коллекций числовых типов возвращается непосредственно значение типа T,
//а значение по умолчанию - 0.

//Но мы можем настроить значение по умолчанию, передав его в качестве одного из аргументов:


string[] people = { "Tom", "Bob", "Kate", "Tim", "Mike", "Sam" };

string? firstWith5Chars = people.FirstOrDefault(s => s.Length == 5, "Undefined");
Console.WriteLine(firstWith5Chars); // Undefined

// первый элемент из пустой коллекции строк
string? firstOrDefault = new string[] { }.FirstOrDefault("hello"); // hello - значение по умолчанию
Console.WriteLine(firstOrDefault);  // hello

// первый элемент из пустой коллекции int
int firstNumber = new int[] { }.FirstOrDefault(100); // 100 - значение по умолчанию
Console.WriteLine(firstNumber); // 100

Console.ReadLine();



