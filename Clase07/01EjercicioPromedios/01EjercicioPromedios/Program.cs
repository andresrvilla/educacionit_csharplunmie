using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01EjercicioPromedios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dado un conjunto de notas, calcular:
            // Promedio
            // Nota mas baja
            // Nota mas alta
            Console.WriteLine("***********************");
            Console.WriteLine("*** PROMEDIATOR 1.0 ***");
            Console.WriteLine("***********************");

            Console.Write("Por favor ingrese el nombre del alumno sobre el que quiere generar el informe: ");
            string nombre = Console.ReadLine();

            Console.Write("Por favor ingrese la cantidad de notas de " + nombre + ": ");
            string cantidadNotas = Console.ReadLine();

            int cantidad = Convert.ToInt32(cantidadNotas);
            // Tambien puedo convertirlo con
            //int cantidad = int.Parse(cantidadNotas);

            double[] notas = new double[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Por favor ingrese la nota " + (i + 1) + " de " + cantidad + ": ");
                string notaTexto = Console.ReadLine();
                int nota = Convert.ToInt32(notaTexto);
                notas[i] = nota;
            }

            // Calculo el promedio, maximo y minimo

            double suma = 0;
            double maximo = Double.MinValue;
            double minimo = Double.MaxValue;

            for (int i = 0; i < notas.Length; i++)
            {
                suma += notas[i];

                if (maximo < notas[i])
                {
                    maximo = notas[i];
                }

                if(minimo > notas[i])
                {
                    minimo = notas[i];
                }
            }

            Console.WriteLine("El alumno " + nombre + " tiene " + (suma / cantidad) + " de promedio.");
            Console.WriteLine("El alumno " + nombre + " tiene " + minimo + " de nota minima.");
            Console.WriteLine("El alumno " + nombre + " tiene " + maximo + " de nota maxima.");

            Console.ReadKey();
        }
    }
}
