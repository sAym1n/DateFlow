using DataFlow.Core;

var catalog = new List<Product>
{
    new Product { Id = 1, Name = "Яблоко", Price = 120m },
    new Product { Id = 2, Name = "Хлеб", Price = 60m },
    new Product { Id = 3, Name = "Сыр", Price = 450m }
};
Console.WriteLine($"FindMax на List<Product> = {catalog.FindMax()!.Name}");
catalog.PrintAll("Товар: ");
