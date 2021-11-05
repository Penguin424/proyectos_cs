using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestros
{
    public class clsEmpleados
    {

        private string  _Nombre;
        private decimal _SueldoDiario;
        private int _Edad;

        public clsEmpleados(string Nombre, decimal SueldoDiario, int Edad)
        {
            this._Nombre = Nombre;
            this._SueldoDiario = SueldoDiario;
            this._Edad = Edad;

        }

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public decimal SueldoDiario { get => _SueldoDiario; set => _SueldoDiario = value; }
        public int Edad { get => _Edad; set => _Edad = value; }

        public decimal CalculaSalario(int NumeroDias)
        {
            return _SueldoDiario * NumeroDias;
        }
    }
}
