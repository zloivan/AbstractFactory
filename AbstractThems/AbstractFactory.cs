using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractThems
{
    abstract class AbstractFactory
    {
        public abstract AbstractButton CreateButton();


        public abstract AbstractWindow CreateWindow();
       
    }
}
