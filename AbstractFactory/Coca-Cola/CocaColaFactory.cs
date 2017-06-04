using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Coca_Cola
{
    class CocaColaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            Console.WriteLine("Создается бутылка коллы");
            return new CocaColaBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new CocaColaCover();
        }

        public override AbstractWater CreateWater()
        {
            Console.WriteLine("Создается вода коллы");
            return new CocaColaWater();
        }
    }
}
