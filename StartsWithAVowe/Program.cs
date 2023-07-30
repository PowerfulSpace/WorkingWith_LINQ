
string[] strings =
        {
            "A penny saved is a penny earned.",
            "The early bird catches the worm.",
            "The pen is mightier than the sword."
        };

var earlyBirdQuery =
           from sentence in strings
           let words = sentence.Split(' ')
           from word in words
           let w = word.ToLower()
           where w[0] == 'a' || w[0] == 'e'
               || w[0] == 'i' || w[0] == 'o'
               || w[0] == 'u'
           select word;

foreach (var v in earlyBirdQuery)
{
    Console.WriteLine("\"{0}\" starts with a vowel", v);
}

Console.ReadLine();