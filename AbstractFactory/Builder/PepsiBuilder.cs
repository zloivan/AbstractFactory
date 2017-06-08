using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Builder
{
    class PepsiBuilder : IBuilder
    {
        public void CreateBottle()
        {
            throw new NotImplementedException();
        }

        public void CreateCover()
        {
            throw new NotImplementedException();
        }

        public void CreateWater()
        {
            throw new NotImplementedException();
        }
    }
}
