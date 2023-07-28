
//Обьединяем все цефры путём сложения друг с другом
int[] numbers = { 1, 2, 3, 4, 5 };
int query = numbers.Aggregate((x, y) => x - y);
Console.WriteLine(query);   // -13


//Обьединения массива строк в одну строку
string[] words = { "Gaudeamus", "igitur", "Juvenes", "dum", "sumus" };
var sentence = words.Aggregate("Text:", (first, next) => $"{first} {next}");

Console.WriteLine(sentence);  // Text: Gaudeamus igitur Juvenes dum sumus



//  количество четных чисел, которые больше 10
int[] numbers2 = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
int size = numbers2.Count(i => i % 2 == 0 && i > 10);
Console.WriteLine(size);    // 3

//Для получения суммы значений применяется метод Sum:
int[] numbers3 = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
int sum = numbers3.Sum();
Console.WriteLine(sum);     // 340


//В данном случае вычисляется сумма значений свойств Age объектов Person из массива people.
Person[] people = { new Person("Tom", 37), new Person("Sam", 28), new Person("Bob", 41) };
int ageSum = people.Sum(p => p.Age);
Console.WriteLine(ageSum);     // 106


//Если мы работаем со сложными объектами, то в эти методы передается делегат, который принимает свойство,
//применяемое в вычислениях:
Person[] people2 = { new Person("Tom", 37), new Person("Sam", 28), new Person("Bob", 41) };
int minAge = people2.Min(p => p.Age); // минимальный возраст
int maxAge = people2.Max(p => p.Age); // максимальный возраст
double averageAge = people2.Average(p => p.Age); //средний возраст
Console.WriteLine($"Min Age: {minAge}");           // Min Age: 28
Console.WriteLine($"Max Age: {maxAge}");           // Max Age: 41
Console.WriteLine($"Average Age: {averageAge}");   // Average Age: 35,33




Console.ReadLine();





record class Person(string Name, int Age);