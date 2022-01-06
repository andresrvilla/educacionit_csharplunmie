using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PromediosModularizado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Titulo();
            string nombreAlumno = ObtenerNombreAlumno();
            double[] notas = ObtenerNotasAlumno();
            double promedio = ObtenerPromedio(notas);
            double minimo = ObtenerMinimo(notas);
            double maximo = ObtenerMaximo(notas);
            InformeFinal(nombreAlumno, promedio, maximo, minimo);
            Console.ReadKey();
        }

        private static void InformeFinal(string nombreAlumno, double promedio, double maximo, double minimo)
        {
            Console.WriteLine("El alumno " + nombreAlumno + " tiene " + promedio + " de promedio.");
            Console.WriteLine("El alumno " + nombreAlumno + " tiene " + minimo + " de nota minima.");
            Console.WriteLine("El alumno " + nombreAlumno + " tiene " + maximo + " de nota maxima  .");
        }

        private static double ObtenerMinimo(double[] notas)
        {
            double minimo = Double.MaxValue;

            for (int j = 0; j < notas.Length; j++)
            {
                if (minimo > notas[j])
                {
                    minimo = notas[j];
                }
            }

            return minimo;
        }

        private static double ObtenerMaximo(double[] notas)
        {
            double maximo = Double.MinValue;

            for (int j = 0; j < notas.Length; j++)
            {
                if (maximo < notas[j])
                {
                    maximo = notas[j];
                }
            }
            return maximo;
        }

        private static double ObtenerPromedio(double[] notas)
        {
            double suma = 0;

            for (int j = 0; j < notas.Length; j++)
            {
                suma += notas[j];
            }

            return suma / notas.Length;
        }

        private static double[] ObtenerNotasAlumno()
        {
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

                if (ingresaMas == "s" || ingresaMas == "S")
                {
                    sigueIngresando = true;
                }
                else
                {
                    sigueIngresando = false;
                }

            } while (sigueIngresando == true);
            return notas;
        }

        static void Titulo()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("*** PROMEDIATOR 1.1 ***");
            Console.WriteLine("***********************");
        }

        static string ObtenerNombreAlumno()
        {
            Console.Write("Por favor ingrese el nombre del alumno sobre el que quiere generar el informe: ");
            string nombre = Console.ReadLine();
            return nombre;
        }
    }
}
