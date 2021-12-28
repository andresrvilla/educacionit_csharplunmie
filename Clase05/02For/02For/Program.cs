using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ESTRUCTURA DE REPETICION FOR

            for(A;B;C){

            }

            A: Inicializacion de la variable de control
                Ejemplo: int i = 0
            B: Condicion de continuidad del for
                Ejemplo: i < 10
            C: Cambio de la variable de control
                Ejemplo: i++
                Ejemplo: i = i + 10
            
            TODOS LOS BLOQUES SON OPCIONALES
            Bucle infinito:
            for(;;){

            }
             */

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Vuelta " + i);
            }

            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Vuelta " + i);
            }
            Console.ReadKey();
        }
    }
}
