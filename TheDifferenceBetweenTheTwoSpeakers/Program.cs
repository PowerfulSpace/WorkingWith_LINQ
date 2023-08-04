

// Create the IEnumerable data sources.  
string[] names1 = System.IO.File.ReadAllLines(@"D:\Testing\Test.txt");
string[] names2 = System.IO.File.ReadAllLines(@"D:\Testing\Test2.txt");

// Create the query. Note that method syntax must be used here.  
IEnumerable<string> differenceQuery =
  names1.Except(names2);

// Execute the query.  
Console.WriteLine("The following lines are in names1.txt but not names2.txt");
foreach (string s in differenceQuery)
    Console.WriteLine(s);


Console.ReadLine();



