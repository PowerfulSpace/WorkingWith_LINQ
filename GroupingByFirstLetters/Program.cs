





// Create a data source.
string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

// Create the query.
var wordGroups =
    from w in words
    group w by w[0];

// Execute the query.
foreach (var wordGroup in wordGroups)
{
    Console.WriteLine("Words that start with the letter '{0}':", wordGroup.Key);
    foreach (var word in wordGroup)
    {
        Console.WriteLine(word);
    }
}




Console.ReadLine();

