using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Builder
{
    interface IBuilder
    {
        void CreateBottle();
        void CreateWater();
        void CreateCover();

        ReadyBottle GetBottle();
        
        
    }
}
