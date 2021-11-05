using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class clsClienteConContacto : clsClienteBase, IMetodos
    {

        public clsClienteConContacto(int id, string nombre, string rFC, int tipoRegimen, string nombreDeContacto) : base(id, nombre, rFC, tipoRegimen, nombreDeContacto)
        {

        }

        public void printName()
        {
            Console.WriteLine(Nombre);
        }
    }
}
