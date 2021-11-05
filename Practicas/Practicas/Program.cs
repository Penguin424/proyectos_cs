using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    class Program
    {
        static void Main(String[] args)
        {
            // TiposDeDatos();
            // TiposDeDatosConvert();
            Condicionales();
        }

        static void TiposDeDatos()
        {
            int i = 10;
            decimal x = 0.0m;
            float f = 0.0f;
            double d = 0.0D;
            string cadena = "Hola, Mundo";
            bool isBandera = false;
            DateTime fecha = DateTime.Now;


            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de x es: {0:C}", x);
            Console.WriteLine("El valor de f es: {0:F2}", f);
            Console.WriteLine("El valor de d es: {0:F2}", d);
            Console.WriteLine("El valor de cadena es: " + cadena);
            Console.WriteLine("El valor de isBandera es: " + isBandera.ToString());
            Console.WriteLine("El valor de fecha es: " + fecha.ToShortDateString());



            Console.ReadKey();
        }

        static void TiposDeDatosConvert()
        {
            int i = 10;
            decimal x = 12.2m;
            float f = 0.0f;
            double d = 0.0D;
            string cadena = "Hola, Mundo";
            bool isBandera = true;
            DateTime fecha = DateTime.Now;
            i = Convert.ToInt32(isBandera);

            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de x es: {0:C}", x);
            Console.WriteLine("El valor de f es: {0:F2}", f);
            Console.WriteLine("El valor de d es: {0:F2}", d);
            Console.WriteLine("El valor de cadena es: " + cadena);
            Console.WriteLine("El valor de isBandera es: " + isBandera.ToString());
            Console.WriteLine("El valor de fecha es: " + fecha.ToShortDateString());



            Console.ReadKey();
        }

        static void Condicionales()
        {
            int valor1 = 0;
            int valor2 = 0;
            string cadena;

            Console.WriteLine("Dame el primer valor:");
            cadena = Console.ReadLine();
            valor1 = Convert.ToInt32(cadena);
            Console.WriteLine("Dame el segundo valor:");
            cadena = Console.ReadLine();
            valor2 = Convert.ToInt32(cadena);

            if (valor1 <= valor2)
            {
                if(valor1 == valor2)
                {
                    Console.WriteLine("Los dos valores son iguales");
                    return;
                } 

                Console.WriteLine("El valor 2 mayor o igual al valor 1");
            } else
            {
                Console.WriteLine("El valor 1 mayor o igual al valor 2");
            }

            Console.ReadKey();
        }

    }
}