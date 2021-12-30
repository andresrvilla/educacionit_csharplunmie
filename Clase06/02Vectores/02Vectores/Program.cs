using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int unNumero = 10;
            int[] variosNumeros = new int[6];

            variosNumeros[0] = 10;
            variosNumeros[1] = 10;
            variosNumeros[2] = 10;
            variosNumeros[3] = 10;
            variosNumeros[4] = 10;
            variosNumeros[5] = 10;
            //variosNumeros[6] = 10; Cuidado! Un indice erroneo genera un error

            float[] notas = { 1, 9, 6, 9, 9, 9, 7, 5 };

            float suma = 0;
            for(int i = 0; i < notas.Length; i++)
            {
                suma += notas[i];
            }
            float promedio = suma / notas.Length;

            Console.WriteLine("El promedio de notas es " + promedio);

            /* UNA APLICACION QUE EL USUARIO PUEDA INGRESAR CUALQUIER
            CANTIDAD DE NOTAS Y SAQUE EL PROMEDIO SIN IMPORTAR CUANTAS
            NOTAS INGRESA EL USUARIO
            */

            Console.Write("Ingrese la cantidad de notas");
            string cantidadNotas = Console.ReadLine();

            // Cargo el array de notas, etc


            //ANEXO
            //Crecer un array

            int[] numeros = new int[2];

            int[] aux = new int[numeros.Length + 1];

            // Copio en aux los numeros que estan en el array numeros
            // y agrego uno nuevo
            // finalmente piso el array original con el nuevo

            numeros = aux;

            Console.ReadKey();
        }
    }
}
