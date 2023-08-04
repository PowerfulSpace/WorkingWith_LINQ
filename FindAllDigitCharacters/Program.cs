


string aString = "ABCDE99F-J74-12-89A";

// Выбрать все символы цифры в строке
IEnumerable<char> stringQuery =
  from ch in aString
  where Char.IsDigit(ch)
  select ch;

// Execute the query  
foreach (char c in stringQuery)
    Console.Write(c + " ");

// Call the Count method on the existing query.  
int count = stringQuery.Count();
Console.WriteLine("Count = {0}", count);

// Выбрать все символы до первого символа '-'  
IEnumerable<char> stringQuery2 = aString.TakeWhile(c => c != '-');

// Execute the second query  
foreach (char c in stringQuery2)
    Console.Write(c);

Console.ReadLine();


