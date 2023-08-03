

int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var myQuery1 = QueryMethod1(nums);

Console.WriteLine("Results of executing myQuery1:");
foreach (var s in myQuery1)
{
    Console.Write(s + " ");
}

Console.WriteLine("\nResults of executing myQuery1 directly:");
foreach (var s in QueryMethod1(nums))
{
    Console.Write(s + " ");
}

QueryMethod2(nums, out IEnumerable<string> myQuery2);
Console.WriteLine("\nResults of executing myQuery2:");
foreach (var s in myQuery2)
{
    Console.Write(s + " ");
}

myQuery1 =
    from item in myQuery1
    orderby item descending
    select item;

// Execute the modified query.
Console.WriteLine("\nResults of executing modified myQuery1:");
foreach (var s in myQuery1)
{
    Console.Write(s + " ");
}





Console.ReadLine();

static IEnumerable<string> QueryMethod1(int[] ints) =>
    from i in ints
    where i > 4
    select i.ToString();

static void QueryMethod2(int[] ints, out IEnumerable<string> returnQ) =>
    returnQ =
        from i in ints
        where i < 4
        select i.ToString();