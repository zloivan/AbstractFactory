using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractThems.blue
{
    class BlueFactory : AbstractFactory
    {
        public override AbstractButton CreateButton()
        {
            return new BlueButton();

        }

        public override AbstractWindow CreateWindow()
        {
            return new BlueWindow();
        }
    }
}
