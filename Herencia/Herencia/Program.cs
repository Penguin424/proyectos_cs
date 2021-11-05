using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            clsClienteVentas clienteVentas = new clsClienteVentas();

            clienteVentas.IdCliente = 1;
            clienteVentas.Nombre = "Juan Pablo";
            clienteVentas.Apellidos = "Rizo Quintero";
            clienteVentas.RFC = "ABCD";
            clienteVentas.Direccion = "Republica de costa rica #325";
            clienteVentas.Colonia = "Quintero";
            clienteVentas.Municipio = "Tlaquepaque";
            clienteVentas.EsCredito = true;

        }
    }
}
