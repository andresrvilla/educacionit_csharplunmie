using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03EjercicioMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] opciones = { "Cuentas", "Promedios", "Informes" };
            int opcionElegida = Menu(opciones);

            Console.WriteLine("Usted eligio " + opciones[opcionElegida]);
            Console.ReadKey();

            switch (opcionElegida)
            {
                case 0:
                    // Presento las operaciones de cuentas:
                    opciones = new string[] { "Sumar", "Restar", "Multiplicar", "Dividir", "Modulo" };
                    opcionElegida = Menu(opciones);
                    Console.WriteLine("Usted eligio " + opciones[opcionElegida]);
                    break;
                case 1:
                    // Presento los promedios...
                    break;
                case 2:
                    // Presento los informes...
                    break;
            }

            Console.WriteLine("Fin del programa...");
            Console.ReadKey();
        }

        static int Menu(string[] opciones)
        {
            int indice = -1;
            while (indice < 0 || indice > opciones.Length - 1)
            {
                Console.Clear();
                Console.WriteLine("MENU...");

                for (int i = 0; i < opciones.Length; i++)
                {
                    Console.WriteLine((i + 1) + " - " + opciones[i]);
                }

                Console.Write("Ingrese la opción elegida: ");
                string opcion = Console.ReadLine();
                indice = Convert.ToInt32(opcion) - 1;
            }
            return indice;
        }
    }
}
