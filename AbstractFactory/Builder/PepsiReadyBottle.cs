using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Pepsi;
namespace AbstractFactory.Builder
{
    class PepsiReadyBottle
    {
        PepsiBottle bottle = new PepsiBottle();
        PepsiWater water = new PepsiWater();
        PepsiCover cover = new PepsiCover();


    }
}
