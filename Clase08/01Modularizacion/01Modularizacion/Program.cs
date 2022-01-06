using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Modularizacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Titulo();
            int suma = SumarEnteros(15, 30);
            Console.WriteLine(suma);
            Console.WriteLine(SumarEnteros(10, 10));

            int precio = 150;
            int impuesto = 20;

            int valorFinal = SumarEnteros(precio, impuesto);
            int otroValorFinal = SumarEnteros(200, impuesto);
            Console.ReadKey();
        }

        // FUNCIONES
        static int SumarEnteros(int numeroUno, int numeroDos)
        {
            // PASO A PASO
            int resultado = numeroUno + numeroDos;
            return resultado;
        }

        // FUNCIONES
        static int Cuadrado(int numero)
        {
            int resultado = numero * numero;
            return resultado;
        }

        // FUNCION
        static int[] Agrandar(int[] inicial)
        {
            int[] aux = new int[inicial.Length + 1];
            for (int i = 0; i < inicial.Length; i++)
            {
                aux[i] = inicial[i];
            }
            return aux;
        }

        // PROCEDIMIENTO
        static void Titulo()
        {
            Console.WriteLine("************************");
            Console.WriteLine("*** PRACTICA MODULOS ***");
            Console.WriteLine("************************");
        }
    }
}
