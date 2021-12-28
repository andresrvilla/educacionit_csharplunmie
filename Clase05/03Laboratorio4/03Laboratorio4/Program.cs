using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Laboratorio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //La suma de los numeros impares del 1 al 10
            int suma = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    suma += i; // Equivalente a suma = suma + i
                }
            }

            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
