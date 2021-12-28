using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion = "@@@";

            do
            {
                Console.WriteLine("*************************");
                Console.WriteLine("*** mi super programa ***");
                Console.WriteLine("*************************");

                Console.WriteLine("1- Opcion");
                Console.WriteLine("2- Opcion");
                Console.WriteLine("3- Opcion");
                Console.WriteLine("0- Salir");

                if (opcion == "@@@")
                {
                    Console.Write("Por favor ingrese una opción de menú: ");
                }
                else
                {
                    Console.Write("La opción ingresada es incorrecta. Por favor ingrese una opción nuevamente: ");
                }

                opcion = Console.ReadLine();
                Console.Clear();
            } while (
                opcion != "1" &&
                opcion != "2" &&
                opcion != "3" &&
                opcion != "0");

        }
    }
}
