using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class clsClientes
    {
        private int _idCliente;
        private string _nombre;
        private string _apellidos;


        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
    }
}
