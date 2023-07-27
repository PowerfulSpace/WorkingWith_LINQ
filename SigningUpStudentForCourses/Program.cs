

var courses = new List<Course> { new Course("C#"), new Course("Java") };
var students = new List<Student> { new Student("Tom"), new Student("Bob") };

var enrollments = from course in courses    //  выбираем по одному курсу
                  from student in students       //  выбираем по одному студенту
                  select new { Student = student.Name, Course = course.Title };   // соединяем каждого студента с каждым курсом

foreach (var enrollment in enrollments)
    Console.WriteLine($"{enrollment.Student} - {enrollment.Course}");


Console.ReadLine();

record class Course(string Title);  // учебный курс
record class Student(string Name);  // студент


