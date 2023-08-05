

string[] names = File.ReadAllLines(@"D:\Testing\Names.csv");
string[] scores = File.ReadAllLines(@"D:\Testing\Scores.csv");

IEnumerable<Student> queryNamesScores =
            from nameLine in names
            let splitName = nameLine.Split(',')
            from scoreLine in scores
            let splitScoreLine = scoreLine.Split(',')
            where Convert.ToInt32(splitName[2]) == Convert.ToInt32(splitScoreLine[0])
            select new Student()
            {
                FirstName = splitName[0],
                LastName = splitName[1],
                ID = Convert.ToInt32(splitName[2]),
                ExamScores = (from scoreAsText in splitScoreLine.Skip(1)
                              select Convert.ToInt32(scoreAsText)).
                              ToList()
            };

// Optional. Store the newly created student objects in memory
// for faster access in future queries. This could be useful with
// very large data files.
List<Student> students = queryNamesScores.ToList();

// Display each student's name and exam score average.
foreach (var student in students)
{
    Console.WriteLine("The average score of {0} {1} is {2}.",
        student.FirstName, student.LastName,
        student.ExamScores.Average());
}

Console.ReadLine();


class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int ID { get; set; }
    public List<int> ExamScores { get; set; }
}



//111, 97, 92, 81, 60
//112, 75, 84, 91, 39
//113, 88, 94, 65, 91
//114, 97, 89, 85, 82
//115, 35, 72, 91, 70
//116, 99, 86, 90, 94
//117, 93, 92, 80, 87
//118, 92, 90, 83, 78
//119, 68, 79, 88, 92
//120, 99, 82, 81, 79
//121, 96, 85, 91, 60
//122, 94, 92, 91, 91  



//Omelchenko,Svetlana,111
//O 'Donnell,Claire,112  
//Mortensen,Sven,113
//Garcia,Cesar,114
//Garcia,Debra,115
//Fakhouri,Fadi,116
//Feng,Hanying,117
//Garcia,Hugo,118
//Tucker,Lance,119
//Adams,Terry,120
//Zabokritski,Eugene,121
//Tucker,Michael,122  