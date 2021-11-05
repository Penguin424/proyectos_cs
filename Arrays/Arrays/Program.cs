using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string cadena;

            for ( int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresa un numero: ");
                cadena = Console.ReadLine();
                list.Add(Convert.ToInt32(cadena));
            }

            int suma = list.Aggregate(0, (value, nextValue) => value + nextValue);
            double promedio = (double)suma / list.Count;
            Console.WriteLine("La suma de los numeros es: {0} ", suma);
            Console.WriteLine("El promedio de los numeros es: {0}", promedio);

            Console.ReadKey();
        }
    }
}
