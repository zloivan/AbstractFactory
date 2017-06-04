using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class AbstractWater
    {
        public abstract string Name { get;}

        public virtual void InteractWithCover(AbstractCover cover)
        {
            Console.WriteLine($"{this.Name} закрывается {cover.Name}");
        }
    }
}
