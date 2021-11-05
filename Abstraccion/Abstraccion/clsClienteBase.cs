using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class clsClienteBase : clsAbsClientes, IMetodos
    {
        


        public clsClienteBase(int id, string nombre, string rFC, int tipoRegimen, string nombreDeContacto)
        {
            Id = id;
            Nombre = nombre;
            RFC = rFC;
            TipoRegimen = tipoRegimen;
            NombreDeContacto = nombreDeContacto;
        }

        public override int Id { get; set; }
        public override string Nombre { get; set; }
        public override string RFC { get; set; }
        public override int TipoRegimen { get; set; }
        public override string NombreDeContacto { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void printName()
        {
            Console.WriteLine(Nombre);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
