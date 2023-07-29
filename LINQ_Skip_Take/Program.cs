


//Если в массиве первый элемент имел бы длину больше или меньше 3 символов,
//то цепочка пропускаемых элементов прервалась бы уже на первом элементе,
//и поэтому метод SkipWhile возвратил бы все элементы массива.
string[] people = { "Tom", "Sam", "Mike", "Kate", "Bob" };
// пропускаем первые элементы, длина которых равна 3
var result = people.SkipWhile(p => p.Length == 3);    // "Mike", "Kate", "Bob"

foreach (var person in result)
    Console.WriteLine(person);
Console.WriteLine(new string('-',20));


string[] people2 = { "Tom", "Sam", "Mike", "Kate", "Bob", "Alice" };
// пропускаем 3 элемента и выбираем 2 элемента
var result2 = people2.Skip(3).Take(2);    // "Kate", "Bob"

foreach (var person in result2)
    Console.WriteLine(person);



Console.ReadLine();


