



Person[] people2 = { new Person("Tom", 37), new Person("Sam", 28), new Person("Bob", 41) };

int minAge = people2.Min(p => p.Age); // минимальный возраст
int maxAge = people2.Max(p => p.Age); // максимальный возраст
double averageAge = people2.Average(p => p.Age); //средний возраст

Console.WriteLine($"Min Age: {minAge}");           // Min Age: 28
Console.WriteLine($"Max Age: {maxAge}");           // Max Age: 41
Console.WriteLine($"Average Age: {averageAge}");   // Average Age: 35,33

Console.ReadLine();


record class Person(string Name, int Age);