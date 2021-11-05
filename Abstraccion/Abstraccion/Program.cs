using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsClienteBase cliente = new clsClienteBase(1, "JUAN PABLO RIZO QUINTERO", "ABS", 1, "PABLO RIZO");

            cliente.printName();

            Console.ReadKey();
        }
    }
}
