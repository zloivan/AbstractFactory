using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Fanta
{
    class FantaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            Console.WriteLine("Бутылка фанты создана.");
            return new FantaBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new FantaCover();
        }

        public override AbstractWater CreateWater()
        {
            Console.WriteLine("Вода фанты создана.");
            return new FantaWater();
        }
    }
}
