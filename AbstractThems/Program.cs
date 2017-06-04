using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractThems
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;
            client = new Client(new blue.BlueFactory());

            client.Run();

            client = new Client(new black.BlackFactory());

            client.Run();
            
        }
    }
}
