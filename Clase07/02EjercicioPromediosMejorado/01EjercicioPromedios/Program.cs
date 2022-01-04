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

            bool sigueIngresando = true;
            double[] notas = new double[0];
            int i = 0;
            do
            {
                double[] aux = new double[notas.Length + 1];
                for (int j = 0; j < notas.Length; j++)
                {
                    aux[j] = notas[j];
                }

                notas = aux;

                Console.Write("Por favor ingrese la nota: ");
                string notaTexto = Console.ReadLine();
                int nota = Convert.ToInt32(notaTexto);
                notas[i] = nota;
                i++;

                Console.Write("¿Desea ingresar mas notas? s / N: ");
                string ingresaMas = Console.ReadLine();

                if(ingresaMas == "s" || ingresaMas == "S")
                {
                    sigueIngresando = true;
                }
                else
                {
                    sigueIngresando = false;
                }

            } while (sigueIngresando == true);


            // Calculo el promedio, maximo y minimo

            double suma = 0;
            double maximo = Double.MinValue;
            double minimo = Double.MaxValue;

            for (int j = 0; j < notas.Length; j++)
            {
                suma += notas[j];

                if (maximo < notas[j])
                {
                    maximo = notas[j];
                }

                if(minimo > notas[j])
                {
                    minimo = notas[j];
                }
            }

            Console.WriteLine("El alumno " + nombre + " tiene " + (suma / notas.Length) + " de promedio.");
            Console.WriteLine("El alumno " + nombre + " tiene " + minimo + " de nota minima.");
            Console.WriteLine("El alumno " + nombre + " tiene " + maximo + " de nota maxima  .");

            Console.ReadKey();
        }
    }
}
