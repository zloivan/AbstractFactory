using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Coca_Cola
{
    class CocaColaBottle : AbstractBottle
    {
        public override string Name => "Бутылка Кока-Колы";

        public override void Interact(AbstractWater water)
        {
            base.Interact(water);
        }
    }
}
