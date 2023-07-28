



string[] soft = { "Microsoft", "Google", "Apple", "Microsoft", "Google" };

// удаление дублей
var result = soft.Distinct();

foreach (string s in result)
    Console.WriteLine(s);

Console.ReadLine();

