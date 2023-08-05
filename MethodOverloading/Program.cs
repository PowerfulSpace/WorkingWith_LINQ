

double[] numbers = { 1.9, 2, 8, 4, 5.7, 6, 7.2, 0 };
var query = numbers.Median();

Console.WriteLine($"double: Median = {query}");

int[] numbers2 = { 1, 2, 3, 4, 5 };
var query2 = numbers2.Median();
Console.WriteLine($"int: Median = {query2}");

int[] numbers3 = { 1, 2, 3, 4, 5 };
var query3 = numbers3.Median(num => num);
Console.WriteLine($"int: Median = {query3}");


string[] numbers4 = { "one", "two", "three", "four", "five" };
var query4 = numbers4.Median(str => str.Length);
Console.WriteLine($"string: Median = {query4}");

string[] strings = { "a", "b", "c", "d", "e" };
var query5 = strings.AlternateElements();
foreach (var element in query5)
{
    Console.WriteLine(element);
}


Console.ReadLine();

public static class EnumerableExtension
{
    public static double Median(this IEnumerable<double>? source)
    {
        if (source is null || !source.Any())
        {
            throw new InvalidOperationException("Cannot compute median for a null or empty set.");
        }

        var sortedList =
            source.OrderBy(number => number).ToList();

        int itemIndex = sortedList.Count / 2;

        if (sortedList.Count % 2 == 0)
        {
            // Even number of items.
            return (sortedList[itemIndex] + sortedList[itemIndex - 1]) / 2;
        }
        else
        {
            // Odd number of items.
            return sortedList[itemIndex];
        }
    }
    public static double Median(this IEnumerable<int> source) =>
    (from number in source select (double)number).Median();

    public static double Median<T>(
    this IEnumerable<T> numbers, Func<T, double> selector) =>
    (from num in numbers select selector(num)).Median();

    public static IEnumerable<T> AlternateElements<T>(this IEnumerable<T> source)
    {
        int index = 0;
        foreach (T element in source)
        {
            if (index % 2 == 0)
            {
                yield return element;
            }

            index++;
        }
    }
}