using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pepsi
{
    class PepsiFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            Console.WriteLine("Создается бутылка пепси");
            return new PepsiBottle();
        }

        public override AbstractCover CreateCover()
        {
            Console.WriteLine("Создается наклейка для пепси бутылки");
            return new PepsiCover();
        }

        public override AbstractWater CreateWater()
        {
            Console.WriteLine("Создается вода пепси");
            return new PepsiWater();
        }
    }
}
