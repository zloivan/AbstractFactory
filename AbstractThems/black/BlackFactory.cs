using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractThems.black
{
    class BlackFactory : AbstractFactory
    {
        public override AbstractButton CreateButton()
        {
            return new BlackButton();
        }

        public override AbstractWindow CreateWindow()
        {
            return new BlackWindow();
        }
    }
}
