using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ArrayMultidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] cuadradoEnteros = new int[3, 4]; //matriz de 3 x 3
            cuadradoEnteros[0, 0] = 1;
            cuadradoEnteros[0, 1] = 2;
            cuadradoEnteros[0, 2] = 3;
            cuadradoEnteros[1, 0] = 4;
            cuadradoEnteros[1, 1] = 5;
            cuadradoEnteros[1, 2] = 6;
            cuadradoEnteros[2, 0] = 7;
            cuadradoEnteros[2, 1] = 8;
            cuadradoEnteros[2, 2] = 9;

            for (int i = 0; i < cuadradoEnteros.GetLength(0); i++)
            {
                for (int j = 0; j < cuadradoEnteros.GetLength(1); j++)
                {
                    Console.WriteLine(" i = " + i + " j = " + j + " valor " + cuadradoEnteros[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
