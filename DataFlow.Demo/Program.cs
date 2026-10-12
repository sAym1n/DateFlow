using DataFlow.Core;

var temperature = new Record<double>(20, "°C");
Console.WriteLine($"Исходная запись: {temperature}");
var fahrenheit = RecordMapper.Map(
temperature, (double c) => c * 9 / 5 + 32, "°F");
Console.WriteLine($"double → double: {fahrenheit}");
var category = RecordMapper.Map(
temperature, (double c) => c >= 15 ? "тепло" : "холодно", "Категория");
Console.WriteLine($"double → string: {category}");
var health = new Record<int>(50, "Здоровье");
Console.WriteLine($"int → int: {RecordMapper.Map(health, (int h) => h + 10, "Здоровье сбонусом")}");
Console.WriteLine($"int → bool: {RecordMapper.Map(health, (int h) => h >= 50, "Внорме")}");