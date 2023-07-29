
var courses = new List<Course> { new Course("C#"), new Course("Java") };
var students = new List<Student> { new Student("Tom"), new Student("Bob") };

var enrollments = courses.Zip(students);

foreach (var enrollment in enrollments)
    Console.WriteLine($"{enrollment.First} - {enrollment.Second}");


//int[] numbers = { 1, 2, 3, 4 };
//string[] words = { "one", "two", "three" };

//var numbersAndWords = numbers.Zip(words, (first, second) => first + " " + second);

//foreach (var enrollment in numbersAndWords)
//    Console.WriteLine(enrollment);



Console.ReadLine();


record class Course(string Title);  // учебный курс
record class Student(string Name);  // студент