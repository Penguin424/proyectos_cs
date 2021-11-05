using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public abstract class clsAbsClientes
    {
        public abstract int Id { get; set; }
        public abstract string Nombre { get; set; }
        public abstract string RFC { get; set; }
        public abstract int TipoRegimen { get; set; }
        public abstract string NombreDeContacto { get; set; }
    }
}
