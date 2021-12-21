using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01LaboratiosModulo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Labotorio Modulo 1 EJ A");

            int x = 10;
            int y = 20;

            x = x - y;
            y = y - x;

            Console.WriteLine("El valor de x es {0}", x);
            Console.WriteLine("El valor de y es {0}", y);

            string nombre = "Andres";
            string apellido = "Villa";

            string nombreCompleto = nombre + " " + apellido;

            Console.ReadKey();
        }
    }
}
