using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractThems
{
    class Client
    {
        AbstractButton button;
        AbstractWindow window;

        public Client(AbstractFactory factory)
        {
            window = factory.CreateWindow();
            button = factory.CreateButton();
            
        }

        public void Run()
        {
            window.Interact(button);
        }

    }
}
