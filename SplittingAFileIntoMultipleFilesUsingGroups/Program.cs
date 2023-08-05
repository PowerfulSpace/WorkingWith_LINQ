


string[] fileA = File.ReadAllLines(@"D:\Testing\Test.txt");
string[] fileB = File.ReadAllLines(@"D:\Testing\Test2.txt");
// Concatenate and remove duplicate names based on  
// default string comparer  
var mergeQuery = fileA.Union(fileB);

// Group the names by the first letter in the last name.  
var groupQuery = from name in mergeQuery
                 let n = name.Split(',')
                 group name by n[0][0] into g
                 orderby g.Key
                 select g;

foreach (var g in groupQuery)
{
    // Create the new file name.  
    string fileName = @"D:\Testing\NewTesting\" + g.Key + ".txt";

    // Output to display.  
    Console.WriteLine(g.Key);

    // Write file.  
    using (StreamWriter sw = new StreamWriter(fileName))
    {
        foreach (var item in g)
        {
            sw.WriteLine(item);
            // Output to console for example purposes.  
            Console.WriteLine("   {0}", item);
        }
    }
}



Console.ReadLine();



//Bankov, Peter
//Holm, Michael  
//Garcia, Hugo  
//Potra, Cristina  
//Noriega, Fabricio  
//Aw, Kam Foo  
//Beebe, Ann  
//Toyoshima, Tim  
//Guy, Wey Yuan  
//Garcia, Debra  


//Liu, Jinghao
//Bankov, Peter  
//Holm, Michael  
//Garcia, Hugo  
//Beebe, Ann  
//Gilchrist, Beth  
//Myrcha, Jacek  
//Giakoumakis, Leo  
//McLin, Nkenge  
//El Yassir, Mehdi  