using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFlow.Demo
{
    public abstract class Animal
    {
        public string Name { get; set; } = "";
        public override string ToString() => $"{GetType().Name} по имени {Name}";
    }
    public sealed class Dog : Animal
    {
    }
}
