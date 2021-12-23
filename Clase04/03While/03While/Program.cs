using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;

            while (numero <= 5)
            {
                Console.WriteLine(numero);
                numero++; // numero = numero +1;
            }


            // LABORATORIO MODULO 3 EJERCICIO 2
            Console.WriteLine("EJERCICIO 2");
            int numeroEjDos = 1;
            while (numeroEjDos <= 10)
            {
                Console.WriteLine(numeroEjDos);
                //numeroEjDos = numeroEjDos + 2;
                numeroEjDos += 2;
            }

            // LABORATORIO MODULO 3 EJERCICIO 3
            Console.WriteLine("EJERCICIO 3");
            int numeroEjTres = 10;
            while (numeroEjTres > 0)
            {
                Console.WriteLine(numeroEjTres);
                numeroEjTres--;
            }

            // LABORATORIO MODULO 3 EJERCICIO 4
            // 1 al 10 sin imprimir el 2, 7, 9
            Console.WriteLine("EJERCICIO 4");
            int numeroEjCuatro = 1;

            while (numeroEjCuatro <= 10)
            {
                if (numeroEjCuatro != 2 && numeroEjCuatro != 7 && numeroEjCuatro != 9)
                {
                    Console.WriteLine(numeroEjCuatro);
                }

                numeroEjCuatro++;
            }

            Console.WriteLine("BREAK");
            int a = 0;
            while (a < 10)
            {
                a++;
                Console.WriteLine(a);
                if (a == 5)
                {
                    break;
                }
;            }

            Console.WriteLine("CONTINUE");
            int b = 0;
            while (b < 10)
            {
                b++;
                if (b == 5)
                {
                    continue;
                }
                Console.WriteLine(b);
            }

            Console.ReadKey();
        }
    }
}
