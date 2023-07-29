
int[] numbers = { 1, 2, 3, 4 };
string[] words = { "one", "two", "three" };

var numbersAndWords = numbers.Zip(words, (first, second) => first + " " + second);

foreach (var enrollment in numbersAndWords)
    Console.WriteLine(enrollment);
Console.ReadLine();


record class Course(string Title);  // учебный курс
record class Student(string Name);  // студент