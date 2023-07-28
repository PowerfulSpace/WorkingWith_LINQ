
var people = new List<Person>
{
    new Student("Tom"),
    new Person("Sam"),
    new Student("Bob"),
    new Employee("Mike")
};

var students = people.OfType<Student>();

foreach (var student in students)
    Console.WriteLine(student.Name);



Console.ReadLine();



record class Person(string Name);
record class Student(string Name) : Person(Name);
record class Employee(string Name) : Person(Name);