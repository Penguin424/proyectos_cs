using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmpleados empleado = new clsEmpleados(
                "Juan Pablo Rizo Quintero", 
                645.16m, 
                21
            );
             
            empleado.SueldoDiario = 20.0m;

            decimal total = empleado.CalculaSalario(30);

            Console.WriteLine("El salario mensual del empleado " + empleado.Nombre + "es: " + total.ToString("C"));


            Console.ReadKey();
        }
    }
}
