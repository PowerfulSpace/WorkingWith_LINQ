

string[] people = { "Tom", "Tim", "Bob", "Sam" };

// проверяем, все ли элементы имеют длину в 3 символа
bool allHas3Chars = people.All(s => s.Length == 3);     // true
Console.WriteLine(allHas3Chars);

// проверяем, все ли строки начинаются на T
bool allStartsWithT = people.All(s => s.StartsWith("T"));   // false
Console.WriteLine(allStartsWithT);
//--------------------------------------------------------------------------------


//Метод Any() действует подобным образом, только возвращает true, если хотя бы один элемент коллекции определенному условию:

// проверяем, все ли элементы имеют длину больше 3 символов
bool allHasMore3Chars2 = people.Any(s => s.Length > 3);     // false
Console.WriteLine(allHasMore3Chars2);

// проверяем, все ли строки начинаются на T
bool allStartsWithT2 = people.Any(s => s.StartsWith("T"));   // true
Console.WriteLine(allStartsWithT2);
//--------------------------------------------------------------------------------


// проверяем, есть ли строка Tom
bool hasTom = people.Contains("Tom");     // true
Console.WriteLine(hasTom);

// проверяем, есть ли строка Mike
bool hasMike = people.Contains("Mike");     // false
Console.WriteLine(hasMike);
//--------------------------------------------------------------------------------





Console.ReadLine();



