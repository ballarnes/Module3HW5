using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW5.CompositePattern
{
    public class Composite : Component
    {
        private List<Component> _components = new List<Component>();

        public Composite(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            _components.Add(component);
        }

        public override void Remove(Component component)
        {
            _components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine($"Region: {Name} {(char)31}");
            for (int i = 0; i < _components.Count; i++)
            {
                _components[i].Print();
            }
        }
    }
}
