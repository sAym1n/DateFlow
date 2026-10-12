using DataFlow.Core;

namespace DataFlow.Demo;
// ОШИБКА 1 — инвариантность обобщённого класса
// Ожидается: CS0029
public class Error1
{
    public static void Check()
    {
        Container<Animal> box = new Container<Dog>(new Dog { Name = "Шарик" });
        Console.WriteLine(box);
    }
}