using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HolaMundo
{
    internal class Program
    {
        //http://github.com/andresrvilla/educacionit_csharplunmie
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");

            // Definicion de variable
            /*
             * TIPO NOMBRE;
             */
            string denominacion;

            // denominacion = "Andres";

            Console.WriteLine("Por favor ingrese su nombre: ");

            denominacion = Console.ReadLine();

            Console.WriteLine("Hola " + denominacion);

            Console.ReadLine();
        }
    }
}
