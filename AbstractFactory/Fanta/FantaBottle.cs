using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Fanta
{
    class FantaBottle : AbstractBottle
    {
        public override string Name => "Фанта бутылка";

        public override void Interact(AbstractWater water)
        {
            base.Interact(water);
        }
    }
}
