using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        AbstractBottle _bottle;
        AbstractWater _water;
        AbstractCover _cover;
        public Client(AbstractFactory factory)
        {
            this._cover = factory.CreateCover();
            this._bottle = factory.CreateBottle();
            this._water = factory.CreateWater();
        }

        public void Run()
        {
            _water.InteractWithCover(_cover);
            _bottle.Interact(_water);
        }
    }
}
