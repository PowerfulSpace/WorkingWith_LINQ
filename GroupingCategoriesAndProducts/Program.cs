



List<Category> categories = new()
{
    new(Name: "Beverages", ID: 001),
    new("Condiments", 002),
    new("Vegetables", 003),
    new("Grains", 004),
    new("Fruit", 005)
};

List<Product> products = new()
{
    new(Name: "Cola", CategoryID: 001),
    new("Tea", 001),
    new("Mustard", 002),
    new("Pickles", 002),
    new("Carrots", 003),
    new("Bok Choy", 003),
    new("Peaches", 005),
    new("Melons", 005),
};

var groupJoinQuery2 =
    from category in categories
    join prod in products on category.ID equals prod.CategoryID into prodGroup
    orderby category.Name
    select new
    {
        Category = category.Name,
        Products =
            from prod2 in prodGroup
            orderby prod2.Name
            select prod2
    };

foreach (var productGroup in groupJoinQuery2)
{
    Console.WriteLine(productGroup.Category);
    foreach (var prodItem in productGroup.Products)
    {
        Console.WriteLine($"  {prodItem.Name,-10} {prodItem.CategoryID}");
    }
}

Console.ReadLine();



record Product(string Name, int CategoryID);
record Category(string Name, int ID);