using DataFlow.Core;

namespace DataFlow.Demo;

public class Error1
{
    public static void Check()
    {
        // Container<Animal> box = new Container<Dog>(new Dog { Name = "Шарик" });
        // Console.WriteLine(box);
    }
}

// public interface IProbeContainer<out T>
// {
//     T GetItem();
//     void Put(T item);
// }

public class Error3
{
    public static void Check()
    {
        // var repo = new InMemoryRepository<string>();
        // Console.WriteLine(repo);
    }
}
