using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Coca_Cola;
namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client Client = null;

            
            Client = new Client(new CocaColaFactory());

            Client.Run();

            Client = new Client(new Fanta.FantaFactory());
            Client.Run();

            Client = new Client(new Pepsi.PepsiFactory());

            Client.Run();

        }
    }

}
