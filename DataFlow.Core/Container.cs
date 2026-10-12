using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFlow.Core
{
    public sealed class Container<T> : IContainer<T>
    {
        private readonly T item;
        public Container(T item)
        {
            this.item = item;
        }
        public T GetItem() => item;
    }
}
