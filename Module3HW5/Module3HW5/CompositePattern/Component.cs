using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW5.CompositePattern
{
    public abstract class Component
    {
        public Component(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public virtual void Add(Component component)
        {
        }

        public virtual void Remove(Component component)
        {
        }

        public virtual void Print()
        {
            Console.WriteLine($"City: {Name} {(char)17}");
        }
    }
}
