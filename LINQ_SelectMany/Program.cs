



List<Winner> winners = new List<Winner>()
{
    new Winner(){County = "Argentina",Years = new int[]{1978,1986,2022}},
    new Winner(){County = "England",Years = new int[]{1966}},
    new Winner(){County = "Germany",Years = new int[]{1954,1974,1990,2014}}
};

var quary = winners.SelectMany(x => x.Years, (a, b) => new { Country = a.County, Year = b });

foreach (var item in quary)
{
    Console.WriteLine(item);
}


Console.ReadLine();


class Winner
{
    public string County { get; set; }
    public int[] Years { get; set; }
}