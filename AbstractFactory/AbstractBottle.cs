using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class AbstractBottle
    {
        public abstract string Name { get; }
        public virtual void Interact(AbstractWater water)
        {
            Console.WriteLine($"{water.Name} наливается в {this.Name}.");
        }
            
    }
}
